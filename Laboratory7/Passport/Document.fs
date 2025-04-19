module Document
open System
open System.Text.RegularExpressions

type Passport(firstName: string, lastName: string, patronymic: string, series: string, number: string, issueDate: DateTime, issuedBy: string, birthDate: DateTime, birthPlace: string) =
    let validateFIO (name: string) =
        let pattern = @"^[A-ZА-Я][a-zа-яё]+$"
        if Regex.IsMatch(name, pattern) then name
        else failwith "Неверный формат имени / фамилии / отчества"
    
    let validateSeries (s: string) =
        let pattern = @"^\d{4}$"
        if Regex.IsMatch(s, pattern) then s
        else failwith "Серия паспорта должна состоять из 4 цифр"

    let validateNumber (n: string) =
        let pattern = @"^\d{6}$"
        if Regex.IsMatch(n, pattern) then n
        else failwith "Номер паспорта должен состоять из 6 цифр"

    let validateIssueDate (d: DateTime) =
        if d > DateTime.Now then failwith "Дата выдачи не может быть в будущем"
        elif d.Year < 1900 then failwith"Дата выдачи не может быть раньше 1900 года"
        else d

    let validateBirthDate (d: DateTime) =
        if d > DateTime.Now then failwith "Дата рождения не может быть в будущем"
        elif DateTime.Now.Year - d.Year < 14 then failwith "Владелец паспорта должен быть старше 14 лет"
        else d

    let validatePlace (p: string) =
        let pattern = @"^[А-Яа-яЁё\s\-\.]+$"
        if String.IsNullOrWhiteSpace(p) then failwith "Место выдачи не может быть пустым"
        elif Regex.IsMatch(p, pattern) then p
        else failwith "Место выдачи может содержать только кириллические буквы, пробелы, дефисы и точки"

    // свойства класса
    member val FirstName = validateFIO firstName
    member val LastName = validateFIO lastName
    member val Patronymic = validateFIO patronymic
    member val Series = validateSeries series
    member val Number = validateNumber number
    member val IssueDate = validateIssueDate issueDate
    member val IssuedBy = validatePlace issuedBy
    member val BirthDate = validateBirthDate birthDate
    member val BirthPlace = validatePlace birthPlace

    member this.Print() =
        printfn "Паспорт гражданина РФ"
        printfn "Гражданин: %s %s %s" this.FirstName this.LastName this.Patronymic
        printfn "Серия: %s" this.Series
        printfn "Номер: %s" this.Number
        printfn "Дата выдачи: %s" (this.IssueDate.ToString("dd.MM.yyyy"))
        printfn "Кем выдан: %s" this.IssuedBy
        printfn "Дата рождения: %s" (this.BirthDate.ToString("dd.MM.yyyy"))
        printfn "Место рождения: %s" this.BirthPlace

    override this.ToString() =
        sprintf "Паспорт РФ %s %s %s, серия %s, номер %s, выдан %s %s" this.FirstName this.LastName this.Patronymic this.Series this.Number (this.IssueDate.ToString("dd.MM.yyyy")) this.IssuedBy

    // реализация сравнения по серии и номеру
    interface IComparable with
        member this.CompareTo(obj: obj) =
            match obj with
            | :? Passport as other ->
                let seriesCompare = this.Series.CompareTo(other.Series)
                if seriesCompare <> 0 then seriesCompare
                else this.Number.CompareTo(other.Number)
            | _ -> invalidArg "obj" "Сравнение возможно только с объектами типа Passport"

    // переопределение Equals для сравнения по серии и номеру
    override this.Equals(obj) =
        match obj with
        | :? Passport as other -> this.Series = other.Series && this.Number = other.Number
        | _ -> false

    // переопределение GetHashCode
    override this.GetHashCode() = hash (this.Series, this.Number)