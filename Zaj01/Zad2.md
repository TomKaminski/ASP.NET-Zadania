1. ViewBag/ViewData vs TempData
===========================

Zarówno obiekt ViewBag jak i TempData są dostępne jako właściwości widoku oraz kontrolera.
Powinny być używane do transportowania małej ilości danych z kontrolera do widoku lub w odwrotną stronę oraz pomiędzy widokami.

ViewBag i ViewData stają się użyteczne jeżeli potrzebujemy przekazać dodatkowe dane, które nie pasują do Modelu.


ViewBag oraz ViewData praktycznie różnią się tylko sposobem w jaki się do nich odwołuje - korzystają z tego samego słownika. ViewBag to "wrapper" wokół obiektu ViewData. Można ich użyć do:
 
* Wypełniania rozwijanych list
* Małych grupowanych danych
* Komponentów jak koszyk z zakupami
* Indeksu aktywnej zakładki

Z kolei TempData przydaje się do:

* Przesyłania danych pomiędzy obecnym HTTP Requestem a po nim następującym

TempData to obiekty o bardzo krótkim cyklu życia - powinny być używane tylko i wyłącznie podczas obecnego HTTP Requestu lub następującego po obecnym.
Takie zachowanie obiektu TempData wymaga na developerze stuprocentowej pewności co do następnego Requestu - możemy to uzyskać tylko i wyłącznie poprzez **przekierowanie**. Operacja przekierowania zabija obecny HTTP Request oraz wysyła kod HTTP 302 do klienta,
następnie tworzy nowy request dla widoku który jest wynikiem przekierowania. TempData opiera się na obiekcie Sesji, jednak sesja sama w sobie może przetrwać znacznie dłużej (obiekt TempData jest niszczony zaraz po następującym Requescie).

**Przy operowaniu z większą ilością danych powinniśmy użyć obiektu ViewModel**


-------------------------------------
*Tomasz Kamiński*
