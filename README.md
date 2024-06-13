## Wersja .Net7.0

# Zainstalowane pakiety Nuget:
Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore" Version="7.0.14" 
Microsoft.AspNetCore.Identity.EntityFrameworkCore" Version="7.0.14" Microsoft.AspNetCore.Identity.UI" Version="7.0.14" 
Microsoft.EntityFrameworkCore" Version="7.0.14" 
Microsoft.EntityFrameworkCore.Design" Version="7.0.14" Microsoft.EntityFrameworkCore.Sqlite" Version="7.0.12" Microsoft.EntityFrameworkCore.SqlServer" Version="7.0.14" 
Microsoft.EntityFrameworkCore.Tools" Version="7.0.14" 
Microsoft.VisualStudio.Web.CodeGeneration.Design Version="7.0.11"

## Instalacja

-projekt wymaga zainstalowanego SQLServer 2019
-uruchomienie VisualStudio z projektem i zbudowanie solucji
-nugetPackage komenda na kosoli: update-database


## Połączenie z bazą danych 
Po stworzeniu klasy CoffeeShopDbContext, która dziedziczy po klasie DbContext  (co następnie zostaje zmienione na dziedziczenie po klasie IdenityDbContext)
dodanie ścieżki w  Porgram.cs : 

```
builder.Services.AddDbContext<CoffeeShopDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("CoffeShopDbContextConnetion")));

a w pliku appsetitings.json dodana nazwa serwera i bazy
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "CoffeShopDbContextConnetion": "Server=(localdb)\\MSSQLLocalDB; Database=CoffeeShopDb; Trusted_Connection=True; MultipleActiveResultSets=true"
  }
}
```

## Dane logowania:

Admin ma możliwość edycji, dodawania oraz usuwania produktów. 
Logowanie do konta admina:
Mail: testadmin@gmail.com
Hasło: Test123!
Dane przykładowego użytkownika do logowania, który ma możliwość złożenia zamówienia:
Mail: testuser@gmail.com
Hasło: testUser123!


## Wygląd i możliwości dla użytkownika

Na stornie wykorzystano szablon do wyglądu i stylu projektu. W sklepie na pierwszej stronie wyświetlają się produkty, będące  „na topie”, które bezpośrednio z pierwszej strony można dodać do koszyka poprzez kliknięcie w przycisk „Add to cart”, 
można również zobaczyć szczegóły dotyczące danego produktu naciskając w nazwę produktu, skąd również można dodać produkty do koszyka.  
![Alt](https://raw.githubusercontent.com/paulinapiek/CoffeeShop/master/dokumentation/Obraz1.jpg) 
![Alt](https://raw.githubusercontent.com/paulinapiek/CoffeeShop/master/dokumentation/Obraz2.jpg)
Po dodaniu produktu do koszyka wyświetla się strona z dotychczasowymi dodanymi produktami w koszyku na której znajduje się informacja o ilości wszystkich produktów, lista produktów wraz z nazwą ilością oraz kwotą za dany produkt, jak również zsumowana kwota całego zamówienia.
![Alt](https://raw.githubusercontent.com/paulinapiek/CoffeeShop/master/dokumentation/Obraz3.jpg)
Po naciśnięciu przycisku kosz, produkt zostaje usunięty z listy, natomiast przycisk „Back to shop” przekierowuje na stronę, gdzie znajdują się wszystkie produkty. 
![Alt](https://raw.githubusercontent.com/paulinapiek/CoffeeShop/master/dokumentation/Obraz4.jpg)
Na ten widok można się dostać również poprzez kliknięcie przycisku „Shop now” na pierwszej stronie, bądź przycisku „Shop”, który znajduje się w menu nawigacji.
	
Do pierwszej strony można się dostać klikając w nawigacji ikonkę ![Alt](https://raw.githubusercontent.com/paulinapiek/CoffeeShop/master/dokumentation/Obraz6.jpg)lub przycisk „Home”.

![Alt](https://raw.githubusercontent.com/paulinapiek/CoffeeShop/master/dokumentation/Obraz7.jpg)Ikona pozwala na rozwinięcie i możliwość zarejestrowania się na stronie, lub zalogowania. Zalogowany użytkownik ma możliwość wylogowania się, i tylko użytkownik zarejestrowany i zalogowany może złożyć zamówienie, w przeciwnym razie zostanie przeniesiony do widoku logowania

![Alt] (https://raw.githubusercontent.com/paulinapiek/CoffeeShop/master/dokumentation/Obraz8.jpg)

![Alt] (https://raw.githubusercontent.com/paulinapiek/CoffeeShop/master/dokumentation/Obraz12.gif) Ta ikonka pozwala użytkownikowi na dostanie się do koszyka, pokazuje również w nawiasie ilość produktów znajdujących się w koszyku.
Skąd może przejść dalej przyciskiem „Proceed”, gdzie użytkownik musi wprowadzić swoje dane by złożyć zamówienie
![Alt] (https://raw.githubusercontent.com/paulinapiek/CoffeeShop/master/dokumentation/Obraz9.jpg)

Po naciśnięciu przycisku „Place Order” zamówienie zostaje złożone i zostaje przekierowany do kolejnego widoku, o ile wszystkie wymagane dane zostały wprowadzone, bo w takim wypadku wyświetli się komunikat o błędzie.
![Alt] (https://raw.githubusercontent.com/paulinapiek/CoffeeShop/master/dokumentation/Obraz10.jpg)
Gdzie po naciśnięciu przycisku „Start Shopping Again” zostaje przekierowany spowrotem na stronę ze wszystkimi produktami, a ilość produktów w koszyku zeruje się.
Jeśli koszyk jest pusty, a użytkownik chce podglądnąć jego zawartość zostaje przekierowany do widoku 
![Alt] (https://raw.githubusercontent.com/paulinapiek/CoffeeShop/master/dokumentation/Obraz11.jpg)skąd może zacząć przeglądać wszystkie produkty po naciśnięciu przycisku „Start Shopping” 
