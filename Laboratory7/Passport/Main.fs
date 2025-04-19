open Document
open System

let passport1 = 
    Passport(
        "Василий",
        "Пупкин",
        "Васильевич",
        "1234", 
        "567890", 
        DateTime(2015, 5, 20), 
        "ОУФМС России по г. Москве", 
        DateTime(1980, 10, 15), 
        "г. Москва")

let passport2 = 
    Passport(
        "Мария",
        "Петрова",
        "Федоровна",
        "1234", 
        "567891", 
        DateTime(2018, 3, 10), 
        "ОУФМС России по Санкт-Петербургу", 
        DateTime(1990, 7, 22), 
        "г. Санкт-Петербург")

let passport3 = 
    Passport(
        "Апов",
        "Пеаиовыиатрова",
        "Федоаытлтровна",
        "1235", 
        "000001", 
        DateTime(2020, 1, 15), 
        "ОУФМС России по Новосибирской области", 
        DateTime(2000, 2, 28), 
        "г. Новосибирск")

// Тестирование вывода на экран
printfn "Тестирование вывода паспорта:"
passport1.Print()
printfn ""
passport2.Print()
printfn ""
passport3.Print()
printfn ""

// Тестирование сравнения паспортов
printfn "Сравнение паспортов:"
printfn "passport1 = passport2: %b" (passport1 = passport2)
printfn "passport1 < passport2: %b" ((passport1 :> IComparable).CompareTo(passport2) < 0)
printfn "passport1 < passport3: %b" ((passport1 :> IComparable).CompareTo(passport3) < 0)
printfn ""