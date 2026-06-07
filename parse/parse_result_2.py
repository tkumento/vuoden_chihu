#!/usr/bin/env python3

import sys
import requests
from bs4 import BeautifulSoup


def parse_page(url):
    response = requests.get(url, timeout=30)
    response.raise_for_status()

    soup = BeautifulSoup(response.text, "html.parser")

    title = None
    div_otsikko = soup.find("div", id="divOtsikko")
    if div_otsikko:
        h1 = div_otsikko.find("h1")
        if h1:
            title = h1.get_text(strip=True)

    rows = []
    started = False

    for tr in soup.find_all("tr"):
        if (tr.get("id") or "").startswith("arvostelu"):
            continue

        cells = tr.find_all(["td", "th"], recursive=False)

        if not cells:
            continue

        values = []

        for cell in cells:
            text = cell.get_text(" ", strip=True)
            if text:
                values.append(text)

        if not values:
            continue

        if not started:
            if len(values) == 1 and values[0] == "Urokset":
                started = True
            else:
                continue

        # Normalize dog result rows:
        # 5-column rows become 6-column rows
        if (
                len(values) == 5
                and values[0].isdigit()
        ):
            values.insert(4, "")

        rows.append(values)

    return title, rows


def filter_rows(rows):
    filtered_rows = []

    for row in rows:
        if len(row) < 6:
            continue

        if not row[0].strip().isdigit():
            continue

        col5 = row[4].strip()
        col6 = row[5].strip()

        # Any placement/title in column 5 qualifies
        if col5:
            filtered_rows.append(row)
            continue

        # Column 5 empty: require more than plain "SA"
        if col6.startswith("SA"):
            remainder = col6[2:].strip(" ,")
            if remainder:
                filtered_rows.append(row)

    return filtered_rows


def print_rows(rows):
    for row in rows:
        print("ROW")
        for idx, value in enumerate(row, start=1):
            print(f"  [{idx}] {value}")
        print()


def main():
    if len(sys.argv) != 2:
        print(f"Usage: {sys.argv[0]} URL", file=sys.stderr)
        printf("To parse show results from https://tulospalvelu.kennelliitto.fi")
        print("py -3 parse_result_2.py \"<url>\"")
        sys.exit(1)

    title, rows = parse_page(sys.argv[1])

# TODO Get judge, warn if multiple judges
# TODO Count puppies
# TODO Count males and females
# TODO Detect ROP and take that gender
# TODO Detect VSP and take that gender
# TODO Breeder classes
# TODO simplified output

    filtered_rows = filter_rows(rows)

    print("TITLE:")
    print(title)
    print()

    print(f"ROWS COLLECTED: {len(rows)}")
    print()

    print_rows(rows)

    print("=" * 60)
    print(f"FILTERED ROWS: {len(filtered_rows)}")
    print("=" * 60)
    print()

    print_rows(filtered_rows)


if __name__ == "__main__":
    main()
