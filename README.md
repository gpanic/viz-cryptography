VIZCryptography
===============
Izdelajte program za šifriranje in dešifriranje poljubne datoteke (npr. zip, exe, doc, ipd.). Program naj podpira algoritma AES in RSA. Pri implementaciji si pomagajte z obstojecimi knjižnicami. Nekaj knjižnic najdete tudi na Moodlu.

V okviru naloge izdelajte aplikacijo, ki vkljucuje naslednje funkcionalnosti:
+ nalaganje izvorne datoteke,
+ nalaganje in shranjevanje šifrirane datoteke,
+ shranjevanje dešifrirane datoteke,
+ šifriranje in dešifriranje poljubne datoteke,
+ kreiranje, nalaganje in shranjevanje kljuca,
+ izbiro dolžine kljuca - pri AES 128, 192 ali 256 bitov, pri RSA 1024 ali 2048 bitov,
+ uporabnika opozori, ce uporabi napacni kljuc:
	+ pri AES mora uporabiti isti kljuce za šifriranje in dešifriranje;
	+ pri RSA mora uporabiti javni kljuc za šifriranje in zasebni za dešifriranje.

Nalogo lahko izvedete s poljubnim programskim orodjem in programskim jezikom. Priporoca se uporaba programskega okolja Eclipse (Java) ali Visual Studio .NET (C#).
Ce uporabljate dodatne knjižnice, jih vkljucite v projekt. Program naj ima okenski uporabniški vmesnik, preko katerega lahko vnesemo parametre in pridobimo rezultate.

Povezave do nekaterih kriptografskih knjižnic za Javo, C# in C++ najdete na Moodlu.

Pri zagovoru naloge je potrebno poznati podrobnosti implementacije, delovanje šifrirnih algoritmov ter okvirno delovanje in strukturo uporabljenih algoritmov AES in RSA.