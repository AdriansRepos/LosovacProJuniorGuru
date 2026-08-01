# Losovač – WinForms aplikace v C#

Losovač je jednoduchá WinForms aplikace vytvořená pro losování výherců ze seznamu soutěžících (vytvořená pro Junior Guru komunitu). Jde o mou první okenní aplikaci.

---

## Funkce aplikace

- Zadání seznamu soutěžících (jméno po jméně)
- Volba počtu výherců, kteří se mají vylosovat
- Náhodné vylosování zadaného počtu jmen ze seznamu
- Smazání soutěžícího ze seznamu
- Automatická oprava zadaného jména na velké počáteční písmeno (i při chybném malém písmeni)

## Průběh losování

Losování má punc dramatičnosti – po dobu dvou sekund běží animace v progress baru, tlačítko **Losovat** je po tuto dobu nefunkční, a po uplynutí této doby se v boxu **Výherci** zobrazí jména vylosovaných.

---

## Struktura projektu

/Losovac

├── Form1.cs

├── Form1.Designer.cs

├── Program.cs

└── README.md

---

### Externí knihovny

- **InputHelper** – automatická oprava zadaného jména na formát s velkým počátečním písmenem (`TitleCase.ToTitleCase`). Losovač používá starší, jednodušší verzi knihovny, protože pracuje pouze se jmény, ne s dalšími typy vstupů (města, validace apod.).

---

## Použité techniky

- WinForms (Windows Forms)
- Práce s `ProgressBar` a `Timer` pro animaci losování
- Náhodný výběr prvků ze seznamu
- Validace a úprava textového vstupu přes sdílenou knihovnu

---

## Release

**v1.0.0** – První vydaná verze. Zadání soutěžících, volba počtu výherců, losování s animací v progress baru.  
[Stáhnout zde](https://github.com/AdriansRepos/LosovacProJuniorGuru/releases/tag/v1.0.0)

**v1.1.0** – Opraven název okna aplikace. Přidána možnost smazání soutěžícího ze seznamu.  
[Stáhnout zde](https://github.com/AdriansRepos/LosovacProJuniorGuru/releases/tag/v1.1.0)

**v1.2.0** – Přidána knihovna `InputHelper` – zadané jméno se nyní automaticky opraví na velké počáteční písmeno i v případě chybného zadání s malým písmenem.  
[Stáhnout zde](https://github.com/AdriansRepos/LosovacProJuniorGuru/releases/tag/v1.2.0)