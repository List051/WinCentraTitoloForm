🎬 **Demo Video:** [Guarda su YouTube](https://youtu.be/VXmUhjv854g)


ModTitoloForm è un modulo che consente di personalizzare la barra del titolo di un form e abilita il trascinamento della finestra con una barra del titolo personalizzata.
 Questo modulo è utile quando desideri rimuovere la barra del titolo predefinita e sostituirla con una personalizzata, aggiungendo anche funzionalità come i pulsanti di chiusura e minimizzazione.
Funzionalità principali
    Personalizzazione della barra del titolo: La routine crea una barra del titolo personalizzata, che include il titolo del form e i pulsanti di controllo (Chiudi e Minimizza).
    Trascinamento del form: La barra del titolo permette di trascinare la finestra, proprio come la barra del titolo predefinita.
    Controllo con pulsanti: I pulsanti "Chiudi" e "Minimizza" sono inclusi per offrire un controllo completo sulla finestra.

Come usare la routine
1. Aggiungi il modulo al tuo progetto
    Aggiungi il modulo ModTitoloForm al tuo progetto.
    Usa il metodo CentraTitolo per personalizzare il titolo del form e abilitare il trascinamento.
2. Esempio di utilizzo
```vbnet
Imports CentraTitolo
 Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim titolo As New TitoloForm()
    titolo.CentraTitolo("Form1", "Gestione Clienti")	
End Sub

