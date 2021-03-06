1. Routing poprzez atrybuty
===========================
Jednym z dodatków, które pojawiły się **ASP.NET MVC 5** był routing 
poprzez atrybuty, pozwala on na określanie adresu URL danych 
akcji kontrolera poprzez atrybut przy akcji. 
Jest to odejście od  *convention-based*
routing, ale możemy łączyć ze sobą te dwa style. 
Równie dobrze możemy dodać taki atrybut do kontrolera, 
który będzie funkcjonował jako prefix. Co prawda 
routing poprzez atrybuty nie spełnia podstawowego celu MVC – 
odseparowania różniących się od siebie części aplikacji. 
Kontroler w żaden sposób nie wpływa na konfigurację routingu, 
zatem używanie routingu poprzez atrybuty miesza 
dwa ważne komponenty aplikacji. 
Standardowo routing poprzez atrybuty jest wyłączony, 
aby go włączyć musimy wywołać metodę `MapMvcAttributeRoutes`
obiektu `RouteCollection`. Tak samo jak w standardowym routingu 
możemy definiować: 

* parametry opcjonalne 
* segmenty ze zmiennymi,
* ograniczać URL do pewnych wartości (*Route constraints*), 
* tworzyć stałe prefixy itd. asd

2. MVC Active and Passive Model
===============================
* **Passive Model Pattern** – model jest nieaktywny, znaczy to, że widok nie jest informowany (przez model) o zmianach jakie  w nim zaszły. Zadanie poinformowania widoku o zmianie modelu przypada kontrolerowi. Kontroler modyfikuje model i zwykle przesyła jego nową kopię do widoku.
* **Active Model Pattern** – model jest aktywny, informuje widok o zmianach jakie dokonuje w nim kontroler.
Docelowo w ASP.NET MVC mamy model pasywny. 

-------------------------------------
*Tomasz Kamiński*
