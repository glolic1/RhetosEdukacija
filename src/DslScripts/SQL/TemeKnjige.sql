
SELECT
    b.ID,
    b.Title,
    NumberOfThemes = COUNT(bt.ID)
FROM
    Bookstore.Book b
    LEFT JOIN Bookstore.BookTheme bt on bt.BookID = b.ID
GROUP BY
            b.ID,
            b.Title