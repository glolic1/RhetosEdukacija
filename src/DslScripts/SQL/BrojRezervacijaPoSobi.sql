
SELECT
    sob.ID, 
    sob.Ime,
    BrojRezervacija = COUNT(rez.ID)
FROM
    Rezervacije.Rezervacija rez
    LEFT JOIN Rezervacije.Soba sob on rez.ID = sob.ID
GROUP BY 
    sob.ID, 
    sob.Ime