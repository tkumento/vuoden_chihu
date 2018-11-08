# coding=utf-8

import csv
import string

def get_prices(string):
    "luo palkintostringi"
    splitted_string = string.split(";")
    ret_string = ""

    #prio 1 VET
    for price_part in splitted_string:
        if 'ROP-VET' == price_part:
            ret_string += ', ROP-VET'
        if 'VSP-VET' == price_part:
            ret_string += ', VSP-VET'

    #prio 2 CACIB/NORD SERT
    for price_part in splitted_string:
        if 'CACIB' == price_part:
            ret_string += ', CACIB'
        if 'VARACA' == price_part:
            ret_string += ', VARA-CACIB'
        if 'NORD SERT' == price_part:
            ret_string += ', NORD SERT'
        if 'VARA-NORD SERT' == price_part:
            ret_string += ', VARA-NORD SERT'

    #prio 3 SERT
    for price_part in splitted_string:
        if 'SERT' == price_part:
            ret_string += ', SERT'
        if 'VARA-SERT' == price_part:
            ret_string += ', VARA-SERT'

    #prio 4 MVA
    for price_part in splitted_string:
        if 'MVA' == price_part:
            ret_string += ', MVA'

    ret_string += ' '
    return ret_string

def output_line(output_file, row, format_string, price_index, index):
    "tulosta PU/PN rivi palkintoineen tiedostoon"
    if row[index]:
        cap_string = string.capwords(row[index].decode('utf-8'))
        enc_string = cap_string.encode('utf-8')
        output_file.write(format_string + get_prices(row[price_index]) + enc_string + '\n')
    return

def output_line_wo_price(output_file, row, format_string, index):
    "tulosta rivi ilman palkintoja tiedostoon"
    if row[index]:
        cap_string = string.capwords(row[index].decode('utf-8'))
        enc_string = cap_string.encode('utf-8')
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
                uros_palkinto = 13
                uros_info_index = 17
                narttu_index = 18
                narttu_palkinto = 22
                narttu_info_index = 26
                pentu_lkm_index = 27
                pentu_index = 29
                vet_lkm_index = 31
                vet_index = 33
                kasv_lkm_index = 35
                kasv_index = 36
                email_index = 40
                info_index = 41
                detection_count = int(row[lkm_index])

                print('Processing: ' + row[paikka_index] + ' ' + row[date_index] + ' ' + row[karva_index])

                #show location
                output_file.write(row[paikka_index].decode('utf-8').upper().encode('utf-8') + ' ')

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
                    output_file.write(date_string + '\n')
                else:
                    #no formatting (yet)
                    output_file.write(row[date_index] + '\n')

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
                output_line_wo_price(output_file, row, '\nTuomari: ', tuomari_index)
                output_file.write('\n')

                #PU & PN
                if 'Uros' == row[rop_index]:
                    #uros ROP
                    output_line(output_file, row, 'ROP, PU-1', uros_palkinto, uros_index)
                    output_line(output_file, row, 'PU-2',(uros_palkinto + 1), (uros_index + 1))
                    output_line(output_file, row, 'PU-3', (uros_palkinto + 2), (uros_index + 2))
                    output_line(output_file, row, 'PU-4', (uros_palkinto + 3), (uros_index + 3))
                    output_line(output_file, row, 'VSP, PN-1', narttu_palkinto, narttu_index)
                    output_line(output_file, row, 'PN-2', (narttu_palkinto + 1), (narttu_index + 1))
                    output_line(output_file, row, 'PN-3', (narttu_palkinto + 2), (narttu_index + 2))
                    output_line(output_file, row, 'PN-4', (narttu_palkinto + 3), (narttu_index + 3))
                else:
                    #narttu ROP
                    output_line(output_file, row, 'ROP, PN-1', narttu_palkinto, narttu_index)
                    output_line(output_file, row, 'PN-2', (narttu_palkinto + 1), (narttu_index + 1))
                    output_line(output_file, row, 'PN-3', (narttu_palkinto + 2), (narttu_index + 2))
                    output_line(output_file, row, 'PN-4', (narttu_palkinto + 3), (narttu_index + 3))
                    output_line(output_file, row, 'VSP, PU-1', uros_palkinto, uros_index)
                    output_line(output_file, row, 'PU-2', (uros_palkinto + 1), (uros_index + 1))
                    output_line(output_file, row, 'PU-3', (uros_palkinto + 2), (uros_index + 2))
                    output_line(output_file, row, 'PU-4', (uros_palkinto + 3), (uros_index + 3))

                #VET
                output_line_wo_price(output_file, row, 'ROP-VET', vet_index)
                output_line_wo_price(output_file, row, 'VSP-VET', (vet_index + 1))

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
                output_file.write('\n\n')

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
