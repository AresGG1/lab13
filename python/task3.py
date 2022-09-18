from enum import Enum

class EuCountriesLanguageCodes(Enum):
    France = "fr_FR"
    German = "de_DE"
    Italian = "it_IT"
    Spanish = "es_ES"
    Polish = "pl_PL"
    Romanian = "ro_RO"
    Dutch = "nl_NL"
    Czech = "cs_CZ"
    Danish = "da_DK"
    Swedish = "sv_SE"

    @classmethod
    def show_full_enum(cls, enum):
        print(enum.name+" = "+enum.value)

    @classmethod
    def show_part_enum(cls, enum, name = False):
        if(name == False):
            print(enum.value)
        elif (name == True):
            print(enum.name)

EuCountriesLanguageCodes.show_part_enum(EuCountriesLanguageCodes.Czech, True)