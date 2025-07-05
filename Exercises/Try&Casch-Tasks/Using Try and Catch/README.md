# Napisz program w C#, który:

- Poprosi użytkownika o podanie liczby całkowitej (jako tekst).

- W bloku try wykona wyłącznie konwersję tego tekstu na typ int (obsłuż potencjalny FormatException).

- Jeżeli parsowanie się nie powiedzie, program powinien wypisać komunikat o błędnym formacie i zakończyć działanie.

- Poza blokiem parsowania, w odrębnym bloku try, podzieli stałą wartość 100 przez wczytaną liczbę (obsłuż potencjalny DivideByZeroException).

- W odpowiednich blokach catch wypisze:

    w przypadku FormatException – „Niepoprawny format liczby!”,

    w przypadku DivideByZeroException – „Nie można dzielić przez zero!”.
