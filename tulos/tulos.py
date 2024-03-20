# coding=utf-8

import csv
import string

def get_prices(string, format_string):
    "luo palkintostringi"
    splitted_string = string.split(";")
    ret_string = ""

    #prio 1 VET
    for price_part in splitted_string:
        if 'ROP-VET' == price_part:
            ret_string += ', ROP-VET'
        if 'VSP-VET' == price_part:
            ret_string += ', VSP-VET'

    #prio 2 VET
    for price_part in splitted_string:
        if 'ROP-JUN' == price_part:
            ret_string += ', ROP-JUN'
        if 'VSP-JUN' == price_part:
            ret_string += ', VSP-JUN'

    #prio 3 CACIB/NORD SERT
    for price_part in splitted_string:
        if 'CACIB' == price_part:
            ret_string += ', CACIB'
        if 'VARACA' == price_part:
            ret_string += ', VARA-CACIB'
        if 'NORD SERT' == price_part:
            ret_string += ', NORD SERT'
        if 'VARA-NORD SERT' == price_part:
            ret_string += ', VARA-NORD SERT'

    #prio 4 SERT
    for price_part in splitted_string:
        if 'SERT' == price_part:
            ret_string += ', SERT'
        if 'VARA-SERT' == price_part:
            ret_string += ', VARA-SERT'

    #prio 5 JUN-SERT
    for price_part in splitted_string:
        if 'JUN-SERT' == price_part:
            ret_string += ', JUN-SERT'

    # prio 6 VET-SERT
    for price_part in splitted_string:
        if 'VET-SERT' == price_part:
            ret_string += ', VET-SERT'

    #prio 7 MVA
    for price_part in splitted_string:
        if 'MVA' == price_part:
            ret_string += ', MVA'

    # prio 8 JUN MVA
    for price_part in splitted_string:
        if 'JUN MVA' == price_part:
            ret_string += ', JUN MVA'

    # prio 9 MVA
    for price_part in splitted_string:
        if 'VET MVA' == price_part:
            ret_string += ', VET MVA'

    # prio 10 J-CACIB
    for price_part in splitted_string:
        if 'J-CACIB' == price_part:
            ret_string += ', J-CACIB'

    # prio 11 V-CACIB
    for price_part in splitted_string:
        if 'V-CACIB' == price_part:
            ret_string += ', V-CACIB'

    # prio 12 NORD JUN-SERT
    for price_part in splitted_string:
        if 'V-CACIB' == price_part:
            ret_string += ', NORD JUN-SERT'

    # prio 13 NORD VET-SERT
    for price_part in splitted_string:
        if 'V-CACIB' == price_part:
            ret_string += ', NORD VET-SERT'

    ret_string += ' '

    if format_string == "":
        ret_string = ret_string[2:]
    return format_string + ret_string

def cap_string(raw_string):
    "capitalize etc string"
    quote = '’'.decode('utf-8')
    cap_string = string.capwords(raw_string.decode('utf-8'))
    rep_string = cap_string.replace(quote, "\'")
    enc_string = rep_string.encode('utf-8')
    return enc_string

def output_line(output_file, row, format_string, price_index, index):
    "tulosta PU/PN rivi palkintoineen tiedostoon"
    if row[index]:
        output_file.write(get_prices(row[price_index], format_string) + cap_string(row[index]) + '\n')
    return

def output_line_wo_price(output_file, row, format_string, index):
    "tulosta rivi ilman palkintoja tiedostoon"
    if row[index]:
        output_file.write(format_string + ' ' + cap_string(row[index]) + '\n')
    return

def output_line_cap(output_file, row, format_string, index):
    "tulosta rivi ilman palkintoja tiedostoon"
    if row[index]:
        dec_string = row[index].decode('utf-8')
        cap_string = "-".join(w.capitalize() for w in dec_string.split('-'))
        new_string = cap_string.title()
        enc_string = new_string.encode('utf-8')
        output_file.write(format_string + ' ' + enc_string + '\n')
    return

def output_line_wo_cap(output_file, row, format_string, index):
    "tulosta rivi ilman palkintoja tiedostoon"
    if row[index]:
        output_file.write(format_string + ' ' + row[index] + '\n')
    return

with open('Vuoden Chihuahua -kisan pistelasku.csv') as File:
    reader = csv.reader(File)
    with open('tulos.txt', 'w+') as output_file:
        for row in reader:
            try:
                pentu = None
                #CSV index config
                tyyppi_index = 1
                karva_index = 2
                paikka_index = 3
                date_index = 4
                tuomari_index = 5
                lkm_index = 6
                rop_index = 8
                uros_index = 9
                muu_uros_index = 13
                uros_palkinto = 18
                uros_info_index = 27
                narttu_index = 28
                muu_narttu_index = 32
                narttu_palkinto = 37
                narttu_info_index = 46
                pentu_lkm_index = 47
                pentu_index = 49
                #vet_sukupuoli_index = 33
                vet_lkm_index = 51
                #vet_index = 34
                #vet_rop_sert_index = 35
                #vet_rop_sert_muu_index = 36
                #vet_rop_sert_muu_palkinto_index = 37
                #vet_vsp_sert_index = 38
                #vet_vsp_sert_muu_index = 40
                #vet_vsp_sert_muu_palkinto_index = 41
                #jun_sukupuoli_index = 42
                #jun_index = 43
                #jun_rop_sert_index = 44
                #jun_rop_sert_muu_index = 45
                #jun_rop_sert_muu_palkinto_index = 46
                #jun_vsp_sert_index = 47
                #jun_vsp_sert_muu_index = 49
                #jun_vsp_sert_muu_palkinto_index = 50
                kasv_lkm_index = 53
                kasv_index = 54
                email_index = 58
                info_index = 59
                detection_count = int(row[lkm_index])

                print('Processing: ' + row[paikka_index].rstrip() + ' ' + row[date_index] + ' ' + row[karva_index])

                #show location
                output_file.write('<h2>')
                output_file.write(row[paikka_index].decode('utf-8').upper().rstrip().encode('utf-8') + ' ')

                #show type
                if('Kansain' in row[tyyppi_index]):
                    output_file.write('KV ')
                if ('Nordic' in row[tyyppi_index]):
                    output_file.write('NORD ')
                if ('Ryhmä' in row[tyyppi_index]):
                    output_file.write('Ryhmä ')
                if ('Erikois' in row[tyyppi_index]):
                    output_file.write('Erikoisnäyttely ')
                if ('pentu' in row[tyyppi_index]):
                    output_file.write('Pentunäyttely ')
                    pentu = True

                #date
                if('-' in row[date_index]):
                    #formatted from yyyy-mm-dd to dd.mm.yyyy
                    splitted_date = row[date_index].split("-")
                    date_string = ".".join([splitted_date[2].lstrip("0"), splitted_date[1].lstrip("0"), splitted_date[0]])
                    output_file.write(date_string + '</h2>\n')
                else:
                    #no formatting (yet)
                    output_file.write(row[date_index] + '</h2>\n')

                #coat
                if ('Lyhyt' in row[karva_index]):
                    output_file.write('Lyhytkarvaiset ')
                else:
                    output_file.write('Pitkäkarvaiset ')

                if pentu == True:
                    #reduced row with only puppy count
                    output_file.write(row[pentu_lkm_index] + '+' + row[pentu_lkm_index + 1])
                else:
                    #counts, vets and breeders if needed
                    output_file.write(row[lkm_index] + '+' + row[lkm_index + 1] + ' (pennut ' + row[pentu_lkm_index] + '+' + row[pentu_lkm_index + 1])
                    if ((int(row[vet_lkm_index]) + int(row[vet_lkm_index + 1])) > 3):
                        output_file.write(', veteraanit ' + str((int(row[vet_lkm_index]) + int(row[vet_lkm_index + 1]))))
                    if int(row[kasv_lkm_index]) > 2:
                        output_file.write(', kasvattajaluokat ' + row[kasv_lkm_index])
                    output_file.write(')')

                #judge
                output_line_cap(output_file, row, '\nTuomari:', tuomari_index)
                output_file.write('\n')

                #PU & PN
                if 'Uros' == row[rop_index]:
                    #uros ROP
                    output_line(output_file, row, 'ROP, PU-1', uros_palkinto, uros_index)
                    output_line(output_file, row, 'PU-2',(uros_palkinto + 1), (uros_index + 1))
                    output_line(output_file, row, 'PU-3', (uros_palkinto + 2), (uros_index + 2))
                    output_line(output_file, row, 'PU-4', (uros_palkinto + 3), (uros_index + 3))
                    output_line(output_file, row, '', (uros_palkinto + 4), (uros_index + 4))
                    output_line(output_file, row, '', (uros_palkinto + 5), (uros_index + 5))
                    output_line(output_file, row, '', (uros_palkinto + 6), (uros_index + 6))
                    output_line(output_file, row, '', (uros_palkinto + 7), (uros_index + 7))
                    output_line(output_file, row, '', (uros_palkinto + 8), (uros_index + 8))
                    #TODO:sijoittumattomien urosten vet/jun tulokset
                    output_line(output_file, row, 'VSP, PN-1', narttu_palkinto, narttu_index)
                    output_line(output_file, row, 'PN-2', (narttu_palkinto + 1), (narttu_index + 1))
                    output_line(output_file, row, 'PN-3', (narttu_palkinto + 2), (narttu_index + 2))
                    output_line(output_file, row, 'PN-4', (narttu_palkinto + 3), (narttu_index + 3))
                    output_line(output_file, row, '', (narttu_palkinto + 4), (narttu_index + 4))
                    output_line(output_file, row, '', (narttu_palkinto + 5), (narttu_index + 5))
                    output_line(output_file, row, '', (narttu_palkinto + 6), (narttu_index + 6))
                    output_line(output_file, row, '', (narttu_palkinto + 7), (narttu_index + 7))
                    output_line(output_file, row, '', (narttu_palkinto + 8), (narttu_index + 8))
                    #TODO:sijoittumattomien narttujen vet/jun tulokset
                else:
                    #narttu ROP
                    output_line(output_file, row, 'ROP, PN-1', narttu_palkinto, narttu_index)
                    output_line(output_file, row, 'PN-2', (narttu_palkinto + 1), (narttu_index + 1))
                    output_line(output_file, row, 'PN-3', (narttu_palkinto + 2), (narttu_index + 2))
                    output_line(output_file, row, 'PN-4', (narttu_palkinto + 3), (narttu_index + 3))
                    output_line(output_file, row, '', (narttu_palkinto + 4), (narttu_index + 4))
                    output_line(output_file, row, '', (narttu_palkinto + 5), (narttu_index + 5))
                    output_line(output_file, row, '', (narttu_palkinto + 6), (narttu_index + 6))
                    output_line(output_file, row, '', (narttu_palkinto + 7), (narttu_index + 7))
                    output_line(output_file, row, '', (narttu_palkinto + 8), (narttu_index + 8))
                    #TODO:sijoittumattomien narttujen vet/jun tulokset
                    output_line(output_file, row, 'VSP, PU-1', uros_palkinto, uros_index)
                    output_line(output_file, row, 'PU-2', (uros_palkinto + 1), (uros_index + 1))
                    output_line(output_file, row, 'PU-3', (uros_palkinto + 2), (uros_index + 2))
                    output_line(output_file, row, 'PU-4', (uros_palkinto + 3), (uros_index + 3))
                    output_line(output_file, row, '', (uros_palkinto + 4), (uros_index + 4))
                    output_line(output_file, row, '', (uros_palkinto + 5), (uros_index + 5))
                    output_line(output_file, row, '', (uros_palkinto + 6), (uros_index + 6))
                    output_line(output_file, row, '', (uros_palkinto + 7), (uros_index + 7))
                    output_line(output_file, row, '', (uros_palkinto + 8), (uros_index + 8))
                    #TODO:sijoittumattomien urosten vet/jun tulokset

                #VET
                #TODO:tätä ei tarvita tässä
                #output_line_wo_price(output_file, row, 'ROP-VET', vet_index)
                #output_line(output_file, row, 'ROP-VET', vet_rop_sert_index, vet_index)
                #output_line(output_file, row, 'VET-SERT', vet_rop_sert_muu_palkinto_index, vet_rop_sert_muu_index )
                #output_line_wo_price(output_file, row, 'VSP-VET', (vet_index + 3))
                #output_line(output_file, row, 'VSP-VET', vet_vsp_sert_index, (vet_index + 4))
                #output_line(output_file, row, 'VET-SERT', vet_vsp_sert_muu_palkinto_index, vet_vsp_sert_muu_index)

                # JUN
                # TODO:tätä ei tarvita tässä
                #output_line_wo_price(output_file, row, 'ROP-JUN', jun_index)
                #output_line(output_file, row, 'ROP-JUN', jun_rop_sert_index, jun_index)
                #output_line(output_file, row, 'JUN-SERT', jun_rop_sert_muu_palkinto_index, jun_rop_sert_muu_index)
                #output_line_wo_price(output_file, row, 'VSP-JUN', (jun_index + 3))
                #output_line(output_file, row, 'VSP-JUN', jun_vsp_sert_index, (jun_index + 4))
                #output_line(output_file, row, 'JUN-SERT', jun_vsp_sert_muu_palkinto_index, jun_vsp_sert_muu_index)

                #Puppy
                #cap_string = string.capwords(row[pentu_index].decode('utf-8'))
                #print(cap_string.encode('utf-8'))
                #print(cap_string)
                #cap_string = row[paikka_index].encode('utf-8').capwords.decode('utf-8')
                output_line_wo_price(output_file, row, 'ROP-Pentu', pentu_index)
                output_line_wo_price(output_file, row, 'VSP-Pentu', (pentu_index + 1))

                #Breeders
                output_line_wo_price(output_file, row, 'ROP-Kasvattaja', kasv_index)
                output_line_wo_price(output_file, row, '2, KP', (kasv_index + 1))
                output_line_wo_price(output_file, row, '3, KP', (kasv_index + 2))
                output_line_wo_price(output_file, row, '4, KP', (kasv_index + 3))
                output_file.write('\n<hr />\n\n')

                #extras
                output_line_wo_cap(output_file, row, 'Uros sert lisätieto:', uros_info_index)
                output_line_wo_cap(output_file, row, 'Narttu sert lisätieto:', narttu_info_index)
                output_line_wo_cap(output_file, row, 'Yhteystieto:', email_index)
                output_line_wo_cap(output_file, row, 'Lisätiedot:', info_index)
                output_file.write('\n\n')
            except ValueError:
                #expected to have header row in CSV
                print('header row ignored')
            except Exception as e:
                print('Other error ' + str(e))

