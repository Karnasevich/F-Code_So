open System

type Category =
| Fiction
| NonFiction
| Science
| History
| Programming
| Other

type BookState =
| Available
| Issued
| Archived

type LibraryBook = {
bookId : int
name : string
writer : string
year : int
category : Category
pageCount : int
state : BookState
}

let library = [
{ bookId = 1; name = "Кобзар"; writer = "Тарас Шевченко"; year = 1840; category = Fiction; pageCount = 320; state = Available }
{ bookId = 2; name = "Мистецтво програмування"; writer = "Дональд Кнут"; year = 1968; category = Programming; pageCount = 650; state = Issued }
{ bookId = 3; name = "Чистий код"; writer = "Robert C. Martin"; year = 2008; category = Programming; pageCount = 450; state = Available }
{ bookId = 4; name = "1984"; writer = "George Orwell"; year = 1949; category = Fiction; pageCount = 328; state = Available }
{ bookId = 5; name = "Sapiens: Людина розумна"; writer = "Yuval Noah Harari"; year = 2011; category = NonFiction; pageCount = 512; state = Issued }
{ bookId = 6; name = "Домашнє кондитерство"; writer = "Умовний автор"; year = 2015; category = NonFiction; pageCount = 220; state = Available }
{ bookId = 7; name = "Історія України"; writer = "Умовний автор"; year = 2003; category = History; pageCount = 300; state = Archived }
{ bookId = 8; name = "Алгоритми. Побудова та аналіз"; writer = "Cormen та ін."; year = 1990; category = Programming; pageCount = 1312; state = Available }
]

let getBookTitles list =
list |> List.map (fun item -> item.name)

let totalPagesByCategory cat list =
list
|> List.filter (fun item -> item.category = cat)
|> List.sumBy (fun item -> item.pageCount)

let averagePages list =
if List.isEmpty list then
0.0
else
let total = list |> List.sumBy (fun item -> item.pageCount)
float total / float (List.length list)

[]
let main argv =

let allTitles = getBookTitles library
let progPages = totalPagesByCategory Programming library
let avg = averagePages library

printfn "titles = %A" allTitles
printfn ""
printfn "pages programming = %d" progPages
printfn ""
printfn "avg pages = %f" avg

0