# System wypożyczania sprzętu

## Opis projektu

Projekt przedstawia prosty system wypożyczania sprzętu napisany w C# jako aplikacja konsolowa.  
Użytkownik może dodawać sprzęt i użytkowników, wypożyczać oraz zwracać sprzęt, zmieniać status urządzeń, wyświetlać aktywne i przeterminowane wypożyczenia oraz generować raport podsumowujący stan systemu.

---

## Funkcjonalności

Aplikacja umożliwia:

- dodawanie użytkowników (Student, Employee)
- dodawanie sprzętu (Laptop, Projector, Camera, VideoMonitor, Router)
- wyświetlanie całego sprzętu wraz ze statusem
- wyświetlanie tylko dostępnego sprzętu
- wypożyczanie sprzętu użytkownikowi
- zwrot sprzętu
- naliczanie kary za spóźniony zwrot
- zmianę statusu sprzętu
- wyświetlanie aktywnych wypożyczeń użytkownika
- wyświetlanie przeterminowanych wypożyczeń
- generowanie raportu
- zapis danych do pliku JSON

---

## Struktura projektu

Projekt został podzielony na kilka części:

### Models

- Equipment  
- User  
- Rental  

Podział ten jest sensowny, ponieważ modele przechowują dane i opisują elementy domeny.

---

### Services

- UserService  
- EquipmentService  
- RentalService  
- ReportService  
- DataService  

Podział ten pozwala oddzielić logikę operacji od modeli oraz od interfejsu konsolowego.

---

### Enums

Zawiera typy wyliczeniowe używane w systemie.

---

### Exceptions

Zawiera własne wyjątki używane przy błędnych operacjach.

---

### Data

Zawiera klasę używaną przy zapisie danych do pliku JSON.

---

### Main.cs

Zawiera menu konsolowe oraz obsługę komunikacji z użytkownikiem.

---

## Kohezja

Kohezja jest widoczna w tym, że każda klasa ma jasno określoną odpowiedzialność:

- User i jego klasy pochodne opisują użytkowników  
- Equipment i klasy pochodne opisują sprzęt  
- Rental opisuje pojedyncze wypożyczenie  
- RentalService odpowiada za logikę wypożyczeń i zwrotów  
- EquipmentService odpowiada za zarządzanie sprzętem  
- ReportService odpowiada za generowanie raportów  
- DataService odpowiada za zapis danych  

---

## Coupling i odpowiedzialność klas

Zależności między klasami zostały ograniczone przez rozdzielenie warstw:

- modele przechowują dane  
- serwisy wykonują operacje i pilnują reguł biznesowych  
- wyjątki obsługują błędne sytuacje  
- Main.cs odpowiada za wejście i wyjście  

Dzięki temu łatwiej wskazać, która część systemu odpowiada za konkretną funkcję.

---

## Decyzje projektowe

Najważniejsze decyzje projektowe:

- użycie klasy bazowej Equipment, ponieważ różne typy sprzętu mają wspólne cechy (id, marka, model, cena, status)
- użycie klasy bazowej User, ponieważ Student i Employee mają wspólne dane
- przeniesienie logiki biznesowej do serwisów zamiast umieszczania jej w Main.cs
- umieszczenie reguł dotyczących limitów i kar w jednym miejscu (RentalService)
- użycie własnych wyjątków do obsługi błędów
- dodanie DataService do obsługi zapisu danych

---

## Instrukcja uruchomienia
1. Sklonować repozytorium z GitHub  
2. Otworzyć projekt w Riderze lub Visual Studio   
3. Uruchomić aplikację  
4. Korzystać z menu w konsoli  

---

## Git i organizacja pracy

Projekt był rozwijany z użyciem kilku gałęzi roboczych:

- feature/models  
- feature/services  
- feature/demo  

Po zakończeniu prac zmiany zostały połączone z gałęzią main.****
