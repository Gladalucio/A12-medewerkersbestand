using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Salaris
{
    public partial class Form1 : Form
    {
        // Een List<> genaamd Medewerker_list wordt aangemaakt.
        List<Medewerker> Medewerker_list = new List<Medewerker>();

        // Een globaal Volgnummer wordt aangemaakt zodat txtVolgnummer.Text altijd de juiste waarde aangeeft.
        int iVolgnummer = 1;

        // Deze Booleans worden aangemaakt zodat er gecontroleerd kan worden door de "TextChecker" of de invoer in de tekstvakken juist is.
        // Standaard is er een waarde van "False", wanneer dit "True" is werken de knoppen "Toevoegen" en "Wijzigen" niet meer totdat dit opgelost is
        bool fNaam = false; bool fPost = false; bool fPost2 = false; bool fCity = false; bool fSalaris = false;

        // Deze Boolean is het 'groene licht' dat de "Toevoegen" en "Wijzigen" knoppen nodig hebben om de Normale Flow in te gaan.
        // Standaardwaarde = false, groen licht = true;
        bool Proceed = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// De ButtonCheck kijkt per actie welke knoppen Enabled of Disabled moeten zijn. Niet alle Enabled/Disabled properties 
        ///   worden hier gewijzigd, sommige worden per Button behandeld. (Bijvoorbeeld: De knop "Wijzigen" wordt geactiveerd 
        ///   door middel van een medewerker te selecteren)
        ///   
        /// 
        /// Wanneer er 1+ mensen in de Listbox ("lstData") staan dan worden de Opslaan en Salaris knoppen aanklikbaar. Zo niet dan 
        ///   moeten Salaris, Opslaan, Verwijderen en Wijzigen uit.
        ///   
        /// </summary>

        private void ButtonCheck()
        {
            // Zijn er één of meer Items in de Listbox (lstData)? Zo ja, activeer de knoppen "Salaris" en "Opslaan".
            if (lstData.Items.Count >= 1)
            {
                btnSalaris.Enabled = true;
                btnOpslaan.Enabled = true;
            }
            // Zo niet dan moeten Salaris, Opslaan, Verwijderen en Wijzigen uit.
            else
            {
                btnSalaris.Enabled = false;
                btnOpslaan.Enabled = false;
                btnVerwijderen.Enabled = false;
                btnWijzigen.Enabled = false;
            }
        }

        /// <summary>
        /// 
        /// De Clear()-functie haalt de tekstblokken leeg en reset de Fault-Booleans. Deze wordt bijna na iedere knop gebruikt zodat 
        ///   er geen onnodige tekst in de tekstblokken blijft staan.
        ///   
        /// </summary>

        private void Clear()
        {
            // De tekst uit de tekstvakken wordt weggehaald.
            txtNaam.Text = "";
            txtAdres.Text = "";
            txtPostcode.Text = "";
            txtPostcode2.Text = "";
            txtWoonplaats.Text = "";
            txtSalaris.Text = "";

            // De Fault-Booleans worden teruggezet op hun startwaarde van "false".
            fNaam = false; fPost = false; fPost = false; fCity = false; fSalaris = false;

            // De Groen-licht Boolean wordt teruggezet naar de standaardwaarde van "false".
            Proceed = false;

            // De ErrorProviders worden weggehaald
            err.Clear();

            // txtNaam wordt gefocussed zodat het netter lijkt aangezien de knoppen niet meer blauw zijn.
            txtNaam.Focus();
        }

        /// <summary>
        /// 
        /// De ListUpdate ververst de Listbox ("lstData") door deze eerst leeg te gooien d.m.v. het "Clear"-commando, het Volgnummer 
        ///   goed te zetten en daarna een for-loop in te gaan voor het toevoegen van de bekende gebruikers.
        /// De For-loop telt het aantal medewerkers en voegt per medewerker het volgnummer, de naam en het salaris toe aan de Listbox.
        /// 
        /// </summary>

        private void ListUpdate()
        {
            lstData.Items.Clear();

            // Het tekstblok met Volgnummer er in wordt naar het hoogst bekende getal ingesteld.
            txtVolgNr.Text = (iVolgnummer).ToString();

            for (int i = 0; i < Medewerker_list.Count; i++)
            {
                lstData.Items.Add(Medewerker_list[i].iVolgNr + ".  " + Medewerker_list[i].sNaam + ",  €" + Medewerker_list[i].iSalaris);
            }
        }

        /// <summary>
        /// 
        /// De TextChecker controleert input van de velden voordat de Wijzigen of Toevoegen knop gebruikt wordt
        /// 
        /// Eerst kijkt de TextChecker of er lege velden zijn d.m.v. een if-statement. Zo niet wordt er gekeken of alle Fault-Booleans (fNaam t/m fSalaris) op "false" staan.
        /// Wanneer dit het geval is dan wordt de Proceed "true" en weten de knoppen dat alles in orde in en voeren zij de toebehorende code uit.
        /// Wanneer niet alle Fault-Booleans op "false" staan dan komt er een error in beeld die pas weg blijft wanneer alle fouten in de tekstvakken opgelost zijn.
        /// 
        /// </summary>

        private void TextChecker()
        {
            // Zijn er tekstvelden leeg? Zo ja, MessageBox met "Niet alle velden zijn ingevuld" en boolean "Proceed" blijft False.
            if (txtNaam.Text == "" || txtAdres.Text == "" | txtPostcode.Text == "" || txtPostcode2.Text == "" || txtSalaris.Text == "" || txtWoonplaats.Text == "")
            {
                Proceed = false;
                MessageBox.Show("Niet alle velden zijn ingevuld. Controleer de invoer en probeer het nog eens", "Leeg tekstblok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                fNaam = false; fPost = false; fPost = false; fCity = false; fSalaris = false;
            }
            // Staan ALLE Fault-Booleans op hun 'normale' waarde van False? Zo ja, boolean "Proceed" krijgt de waarde "true";
            else if (fNaam == false && fPost == false && fPost2 == false && fCity == false && fSalaris == false)
            {
                Proceed = true;
            }
            // Wanneer de tekstvakken en fault-booleans niet aan de bovenstaande vereisten voldoen is er iets nog niet in orde. De melding "Controleer de tekstblokken" wordt weergeven.
            else
            {
                Proceed = false;
                MessageBox.Show("Controleer de tekstblokken en probeer het nog eens", "Ongeldige invoer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary> ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// 
        /// De onderstaande SelectedIndexChanged activeert wanneer een medewerker in de Listbox (lstData) geselecteerd wordt.
        /// 
        /// Eerst worden knoppen gewijzigd, er wordt gekeken welke Medewerker geselecteerd is d.m.v. de SelectedIndex en daarna gaan we het if-statement in.
        /// Dit if-statement moest aangemaakt worden aangezien er anders een Exception komt wanneer "lstData.ClearSelected(); gebruikt wordt om de selectie weg te halen na het klikken op 
        ///   de "Wijzigen"-knop. De Integer die aangemaakt wordt om de juiste persoon in de List te selecteren kreeg een waarde van "-1" en dan crasht het programma aangezien er geen 
        ///   "Medewerker_list[-1]" kan bestaan. Nu worden de gegevens van Medewerker_list[i] alléén geladen wanneer de waarde groter of gelijk is aan 0. 
        ///   
        /// Is deze toch kleiner dan 0 is 
        ///   "lstData.ClearSelected():" gebruikt dus is er geen selectie meer  nodig. Daarom kan dit gebruikt worden om de Toevoegen, Wijzigen en Verwijderen knoppen weer te Enablen of 
        ///   Disablen (het tegenovergestelde als wat er aan het begin van de onderstaande code gedaan wordt)
        ///   
        /// <summary> ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void lstData_SelectedIndexChanged(object sender, EventArgs e)
        {
            // De Toevoegen-knop wordt uitgeschakeld, Wijzigen en Verwijderen worden Enabled.
            btnToevoegen.Enabled = false;
            btnWijzigen.Enabled = true;
            btnVerwijderen.Enabled = true;

            // Een Integer wordt aangemaakt met als waarde de SelectedIndex'ste persoon in de Listbox (lstData).
            int i = lstData.SelectedIndex;

            // Wanneer SelectedIndex >= 0 -> de loop in om de gegevens in te vullen.
            if (i >= 0)
            {
                txtVolgNr.Text = Medewerker_list[i].iVolgNr.ToString();
                txtNaam.Text = Medewerker_list[i].sNaam;
                txtAdres.Text = Medewerker_list[i].sAdres;
                txtPostcode.Text = Medewerker_list[i].sPostcode;
                txtPostcode2.Text = Medewerker_list[i].sPostcode2;
                txtWoonplaats.Text = Medewerker_list[i].sWoonplaats;
                txtSalaris.Text = Medewerker_list[i].iSalaris.ToString();
            }
            // Is de SelectedIndex kleiner dan 0? In dat geval is de selectie vrijgemaakt dus horen de Buttons weer als standaard.
            else
            {
                btnToevoegen.Enabled = true;
                btnWijzigen.Enabled = false;
                btnVerwijderen.Enabled = false;
            }
        }

        /// <summary> /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// 
        /// De Toevoegen-Button:
        /// 
        /// De button vraagt aan de TextChecker-functie om groen licht (boolean Proceed = true) om de normale flow in te gaan. Bij groen  
        ///   licht wordt de Medewerker-class "M" gebruikt als "template" om de informatie uit de tekstblokken in te zetten. De button zet  
        ///   de informatie in de Tekstvakken in een Class "M" en voegt de inhoud van "M" toe aan de globale List<> "Medewerker_list".
        /// 
        /// Het volgnummer wordt na het toevoegen verhoogd met 1 en de Listbox wordt ververst, de tekstblokken leeggemaakt en de knoppen 
        ///   gecontroleerd.
        ///   
        /// <summary> /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            // De TextChecker controleert de invoer en bepaalt of er groen licht gegeven kan worden
            TextChecker();

            // Dit if-statement werkt pas wanneer boolean "Proceed" een waarde van 'true' heeft.
            if (Proceed)
            {
                Medewerker M = new Medewerker();

                M.iVolgNr = iVolgnummer;
                M.sNaam = txtNaam.Text;
                M.sAdres = txtAdres.Text;
                M.sPostcode = txtPostcode.Text;
                M.sPostcode2 = txtPostcode2.Text;
                M.sWoonplaats = txtWoonplaats.Text;
                M.iSalaris = Single.Parse(txtSalaris.Text);

                // De informatie uit de Class "M" wordt aan de globale List<> "Medewerker_list" toegevoegd.
                Medewerker_list.Add(M);

                // De globale Int "iVolgnummer" wordt met één verhoogd
                iVolgnummer++;

                // De Listbox wordt ververst, de tekstblokken leeggemaakt en de knoppen gecontroleerd.
                ListUpdate();
                Clear();
                ButtonCheck();
            }
        }

        /// <summary> /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// 
        /// De Salaris-Button
        /// 
        /// De Salaris-button berekent het gemiddelde salaris van de medewerkers. Eerst wordt er een Single aangemaakt waarin de 
        ///    salarissen bij elkaar opgeteld worden, daarna wordt het totaal gedeeld door het aantal medewerkers in de lijst.
        ///    Vervolgens wordt gemiddelde salaris weergeven in een MessageBox.
        /// 
        /// <summary> /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnSalaris_Click(object sender, EventArgs e)
        {
            // Een Single "jSalaris" wordt aangemaakt waar het salaris in opgeteld en berekend wordt.
            Single jSalaris = 0;

            // De nieuwe "int i" gaat in de for-loop van 0 naar hoeveel mensen er in de List<> aanwezig zijn.
            for (int i = 0; i < Medewerker_list.Count; i++)
            {
                // Single jSalaris krijgt steeds zijn huidige waarde + het salaris van Medewerker_list[i]. Dit gebeurt "i"-aantal keer.
                jSalaris += Medewerker_list[i].iSalaris;
            }
            // Het berekende bedrag wordt gedeeld door het aantal medewerkers in de lijst
            jSalaris = jSalaris / Medewerker_list.Count;

            // Een MessageBox komt naar voren die het gemiddelde salaris weergeeft, afgerond op 2 decimalen.
            MessageBox.Show("Het gemiddelde salaris is:" + Environment.NewLine + Environment.NewLine + jSalaris.ToString("0.00"), "Gemiddeld Salaris", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary> //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// 
        /// De Verwijder-Button
        /// 
        /// De verwijderbutton activeert eerst de Toevoegen-knop zodat deze weer bruikbaar is na het verwijderen van een medewerker uit de Listbox (lstData). Deze valt namelijk buiten wat de
        ///    "ButtonCheck();" doet. Het verwijderen zelf gebeurt door te bepalen wie er geselecteert is m.b.v. "SelectedIndex" en deze waarde te geven aan int "i". De Medewerker wordt
        ///    verwijderd uit de List<> "Medewerker_list" met behulp van ".RemoveAt". Daarna wordt de selectie in de Listbox (lstData) opgeheven en de tekstvelden geleegd, de buttons 
        ///    gecontroleerd en de listbox ververst.
        /// 
        /// <summary> //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            btnToevoegen.Enabled = true;
            // De geselecteerde persoon vinden en deze opslaan in "int i"
            int i = lstData.SelectedIndex;

            // De "i"-ste persoon verwijderen in de List<> "Medewerker_list"
            Medewerker_list.RemoveAt(i);

            // Deselecteert de geselecteerde persoon
            lstData.ClearSelected();

            // Maakt de tekstvelden leeg
            Clear();
            // Updatet de Listbox (lstData)
            ListUpdate();
            // Controleert de Buttons
            ButtonCheck();
        }

        /// <summary> ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// 
        /// De Laden-Button
        /// 
        /// De laadknop laat een dialoogvenster zien en bij "OK" wordt het document geopend, de regels één voor één uitgelezen, in een List<>
        ///   geplaatst ("loadEmployees") die weer lade voor lade uitgelezen en gesplitst wordt in for-loop nr. 1 (de "i") en op de juiste plek in
        ///   de "M"-Class met behulp van for-loop "j" en een switch-case die een hele boel if-statements voorkomt. Wanneer Class "M" gevuld is
        ///   wordt het geheel in de List<> "Medewerker_list" geplaatst. Dit herhaalt net zo vaak tot alle medewerkers geïmporteerd zijn uit het
        ///   .csv-bestand
        ///   
        /// Nadat de List<> "Medewerker_list" alle medewerkers heeft ontvangen wordt het Volgnummer uit het .csv-bestand gehaald. Deze staat naast
        ///   de kop en wordt ook met een String[] uitgelezen. Wanneer het juiste getal gevonden is krijgt de globale variabele "iVolgnummer" deze
        ///   waarde mee zodat, ook al zijn er medewerkers verwijderd, het volgnummer altijd correct is, ook bij meerdere keren opnieuw opslaan.
        /// 
        /// <summary> //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnLaden_Click(object sender, EventArgs e)
        {
            // Een String-list wordt aangemaakt met de naam "loadEmployees"
            List<string> loadEmployees = new List<string>();
            // Een String-Array wordt aangemaakt met 7 lege strings.
            string[] LosseMedewerker = new string[7];

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // De tekstblokken worden leeggehaald
                Clear();
                // De List<> "Medewerker_list" wordt leeggehaald
                Medewerker_list.Clear();
                // De String "FileName" wordt aangemaakt die gelijk staat aan de naam van het te openen .csv-bestand
                string FileName = openFileDialog1.FileName;

                // Het geopende bestand wordt helemaal tot het einde uitgelezen met behulp van de StreamReader "sReader" en 
                //    het resultaat wordt per regel toegevoegd aan List<> "loadEmployees".
                using (StreamReader sReader = new StreamReader(FileName))
                {
                    // Wanneer het einde nog niet is bereikt, doorgaan met lezen
                    while (!sReader.EndOfStream)
                    {
                        // De gehele regel wordt toegevoegd aan de List<> "loadEmployees".
                        loadEmployees.Add(sReader.ReadLine());
                    }
                }
                //////////////////////////////////////////////////////////////////////////////////
                // Tussen-uitleg
                //
                // Vanaf hier is het .csv-bestand niet meer nodig, alle relevante informatie zit namelijk al in de List<> "loadEmployees".
                // loadEmployees[0] bevat informatie die op de volgende manier opgeslagen is, met spaties voor extra leesbaarheid:
                //             Volgnummer ; Naam ; Adres ; Postcode-getallen ; Postcode-letters ; Woonplaats ; Salaris
                // Realiteit:              1;Berry Clappers;Gruttostraat 10;6883;CN;Velp;3500

                // Het enige wat nu nog moet gebeuren is:
                //   1. De List<> "loadEmployees" moet gesplitst worden met als scheidingsteken ";" en de gescheiden stukjes komen terecht in String[] "LosstMedewerker"
                //   2. De afgesplitste stukjes moeten op de juiste plaats teruggezet worden in de List<> "Medewerker_list"
                //////////////////////////////////////////////////////////////////////////////////

                // Een nieuwe, lege string "import" wordt gemaakt
                string import = "";
                // Een int "lineCount" wordt gemaakt die de waarde krijgt van de lengte van het bestand "FileName" (dit is het .csv-bestand)
                int lineCount = File.ReadLines(FileName).Count();

                // Een nieuwe for-loop wordt gestart met als startwaarde van "i" 1 en gaat door tot deze niet langer kleiner is dan "lineCount".
                // De reden dat "i" niet 0 is, is omdat de eerste regel in het .csv-bestand de titelkoppen bevat ("Volgnummer, Naam, Adres, etc.)
                for (int i = 1; i < lineCount; i++)
                {
                    // De string "import" krijgt als waarde één regel uit de List<> "loadEmployees". Die ziet er als volgt uit:
                    //             Volgnummer;Naam;Adres;Postcode-getallen;Postcode-letters;Woonplaats;Salaris
                    import = loadEmployees[i];

                    // De String[] "LosseMedewerker" krijgt door de regel te splitsen op ";" 7 lades met informatie, waarbij LosseMedewerker[0] = Volgnummer en 
                    // LosseMedewerker[6] = Salaris
                    LosseMedewerker = import.Split(';');

                    // De Class "M" wordt opnieuw naar voren getoverd om de informatie uit de String[] "LosseMedewerker" in op te slaan en te exporteren naar de List<> "Medewerker_list"
                    Medewerker M = new Medewerker();

                    // Een for-loop wordt gestart met 7 waardes, van 0 t/m 6.
                    for (int j = 0; j < 7; j++)
                    {
                        // Deze Switch-Case bepaalt waar het stukje informatie terecht moet komen.
                        switch (j)
                        {
                            // Bij j = 0
                            case 0:
                                M.iVolgNr = int.Parse(LosseMedewerker[j]);
                                break;
                            // Bij j = 1
                            case 1:
                                M.sNaam = LosseMedewerker[j];
                                break;
                            // Bij j = 2
                            case 2:
                                M.sAdres = LosseMedewerker[j];
                                break;
                            // Bij j = 3
                            case 3:
                                M.sPostcode = LosseMedewerker[j];
                                break;
                            // Bij j = 4
                            case 4:
                                M.sPostcode2 = LosseMedewerker[j];
                                break;
                            // Bij j = 5
                            case 5:
                                M.sWoonplaats = LosseMedewerker[j];
                                break;
                            // Bij j = 6
                            case 6:
                                M.iSalaris = Single.Parse(LosseMedewerker[j]);
                                break;
                        }
                    }
                    // Na het voltooien van de For-loop zijn alle velden van de Class "M" ingevuld. Nu kan deze toegevoegd worden aan de List<> "Medewerker_list"
                    //   met behulp van de onderstaande "Medewerker_list.Add". Dit gebeurt net zo vaak tot de laatste medewerker toegevoegd is.
                    Medewerker_list.Add(M);
                }
                // Het meest recente volgnummer wordt uit het document gehaald en opgeslagen als het huidige "iVolgnummer". Bij het refreshen van de List ( via ListUpdate() )
                //   komt het laatstgebruikte volgnummer weer bovenaan te staan. Het volgnummer staat naast de kop in het .csv-document, vandaar dat het uitlezen moeilijker werd.
                // Het onderstaande stukje code importeert "loadEmployees[0]", in een string, splitst die string in deeltjes (zoals eerder beschreven) en stopt deze in de
                //   String[] "volgimport". Het laatste plekje in deze Array kan uitgelezen worden (dus volgimport[7]) en dit is de waarde die iVolgnummer moet krijgen.
                string volgnummertje = loadEmployees[0];
                string[] volgimport = new string[8];
                volgimport = volgnummertje.Split(';');
                iVolgnummer = int.Parse(volgimport[7]);
            }
            else
            {
                // Wanneer de gebruiker op 'Annuleren' klikt of het dialoogvenster sluit zonder een keus te maken komt de onderstaande MessageBox naar voren om de gebruiker
                //   te laten weten dat het inladen mislukt is. Er gebeurt verder ook niks.
                MessageBox.Show("Inladen mislukt!", "Mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // ListUpdate en ButtonCheck na het importeren van de medewerkers
            ListUpdate();
            ButtonCheck();
        }
        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //
        /// <summary>
        /// 
        /// De Wijzigen-button
        /// 
        /// De wijzigen-knop werkt op dezelfde manier als de Toevoegen-button, namelijk met de "TextChecker"-functie. Bij groen licht van de boolean "Proceed"
        ///   wordt de geselecteerde persoon bepaald met "SelectedIndex" en wordt de informatie in de List<> "Medewerker_list" bijgewerkt naar de nieuwe invoer.
        /// Daarna weer de gewoonlijke ClearSelected, Clear(), ListUpdate() en ButtonCheck()
        /// 
        /// </summary>
        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //

        private void btnWijzigen_Click(object sender, EventArgs e)
        {
            // De TextChecker controleert de invoer en bepaalt of er groen licht gegeven kan worden
            TextChecker();

            // Dit if-statement werkt pas wanneer boolean "Proceed" een waarde van 'true' heeft.
            if (Proceed)
            {
                // De geselecteerde persoon wordt bepaald met SelectedIndex en deze wordt opgeslagen in "int iVolg"
                int iVolg = lstData.SelectedIndex;

                // De nieuwe informatie wordt opgeslagen in de List<> "Medewerker_list"
                Medewerker_list[iVolg].sNaam = txtNaam.Text;
                Medewerker_list[iVolg].sAdres = txtAdres.Text;
                Medewerker_list[iVolg].sPostcode = txtPostcode.Text;
                Medewerker_list[iVolg].sPostcode2 = txtPostcode2.Text;
                Medewerker_list[iVolg].sWoonplaats = txtWoonplaats.Text;
                Medewerker_list[iVolg].iSalaris = Single.Parse(txtSalaris.Text); // Omdat "Salaris" een Single is moet het geparsed worden natuurlijk

                // De geselecteerde persoon wordt gedeselect, tekstvelden gecleared, list geüpdatet, buttons gechecked.
                lstData.ClearSelected();
                Clear();
                ListUpdate();
                ButtonCheck();
            }
        }

        /// <summary> /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// 
        /// De Opslaan-Button
        /// 
        /// Wanneer de gebruiker op "Opslaan" klikt wordt er een Dialoogvenster geopend. Als er een document op correcte wijze opgeslagen wordt,
        ///   worden de medewerkers medewerker voor medewerker in de lijst geplaatst, onder de kop. De kop bestaat uit:
        ///   Volgnummer;Naam;Adres;Postcode;Postcode2;Woonplaats;Salaris; + iVolgnummer
        /// Het volgnummer staat er ook in zodat deze altijd goed is, ook na meedere keren opslaan of de laatste medewerkers verwijderen.
        /// 
        /// Onder de kop komt alle informatie van de medewerkers, elke medewerker krijgt één regel, de informatie wordt aan elkaar geplakt en
        ///   vervolgens gescheiden met een ";"-teken. Wanneer alle medewerkers in het juiste formaat genoteerd zijn wordt het geheel
        ///   geëxporteerd naar de door de gebruiker gekozen bestandslocatie.
        /// 
        /// <summary> /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            // Wanneer de gebruiker een Filename intypt en op "Ok" klikt start dit if-statement
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // De string "SavePath" is om de Filename makkelijk te gebruiken
                string SavePath = saveFileDialog1.FileName;
                // Hier wordt gebruik gemaakt van een StringBuilder voor het schrijven van het .csv-bestand. Op de eerste regel, de kop, staan de 7 gegevens met daarnaast het hoogst bekende volgnummer zodat deze altijd klopt.
                StringBuilder sb = new StringBuilder("Volgnummer;Naam;Adres;Postcode;Postcode2;Woonplaats;Salaris;" + iVolgnummer + "\r\n");

                // Een for-loop die per bekende Medewerker in de List<> "Medewerker_list" de gegevens in de for-loop op één regel plaatst met zelf-getypte scheidingstekens ";" ertussen.
                for (int j = 0; j < Medewerker_list.Count(); j++)
                {
                    // StringBuilder.Append noteert de gegevens van werknemer "j" en plaatst een ";" tussen de gegevens in.
                    sb.Append(Medewerker_list[j].iVolgNr + ";" + Medewerker_list[j].sNaam + ";" + Medewerker_list[j].sAdres + ";" + Medewerker_list[j].sPostcode + ";" + Medewerker_list[j].sPostcode2 + ";" + Medewerker_list[j].sWoonplaats + ";" + Medewerker_list[j].iSalaris);
                    // AppendLine plaatst een Enter (Environment.Newline) na iedere notatie zodat alles netjes op één regel komt.
                    sb.AppendLine();
                }
                // Dit argument schrijft het hele pakketje met de name "SavePath" naar de door de gebruiker opgegeven directory.
                File.WriteAllText(SavePath, sb.ToString());
            }
            else
            {
                // Wanneer de gebruiker NIET op "Ok" klikt bij het opslaan komt deze MessageBox naar voren.
                MessageBox.Show("Opslaan mislukt!", "Opslaan mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary> /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// 
        /// [xxx]_Leave-argumenten
        /// 
        /// De onderstaande functies worden geactiveerd wanneer de gebruiker een tekstveld 'verlaat'. 
        /// Wanneer de focus wegvalt van het tekstveld controleren de onderstaande functies of de invoer correct is.
        /// 
        /// Bij ieder string_leave-event wordt een Regex gebruikt die controleert op specifieke tekens, cijfers of letters.
        /// Wanneer de invoer NIET voldoet aan de eisen (dus wanneer de "if" geactiveerd wordt en niet de "else") dan komt er
        ///   een rode ErrorProvider achter het desbetreffende tekstblok te staan. Naast dat heeft ieder Leave-event zijn eigen
        ///   globale fault-Boolean. Voor "txtNaam_Leave" is dat de boolean "fNaam". Standaard heeft deze een waarde van "false" maar
        ///   wanneer de invoer incorrect is, verandert deze naar "true". 
        ///   
        /// Wanneer niet ALLE fault-Booleans op "false" staan krijgen de Wijzigen- en Toevoegenknoppen geen 'Groen licht'.  Wanneer de
        ///   fout uit de tekstbox gehaald wordt, verdwijnt de ErrorProvider weer en verandert de fault-Boolean terug naar "false", dan
        ///   zijn er dus geen fouten meer.
        ///
        /// De onderstaande events krijgen geen verdere uitleg behalve waar nodig, de rest staat hierboven uitgelegd.
        /// </summary> /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void txtNaam_Leave(object sender, EventArgs e)
        {
            // De Regex laat alleen hoofdletters, kleine letters en spaties toe. Wanneer er iets anders gezien wordt is de invoer incorrect.
            if (!Regex.IsMatch(txtNaam.Text, "^[a-zA-Z ]*$"))
            {
                err.SetError(txtNaam, "Naam kan alleen letters en spaties bevatten");
                fNaam = true;
            }
            else
            {
                err.SetError(txtNaam, string.Empty);
                fNaam = false;
            }
        }

        private void txtPostcode_Leave(object sender, EventArgs e)
        {
            // De Regex laat alleen getallen van 1 tot 9 toe en dit 4x. Afwijkende invoer is incorrect.
            if (!Regex.IsMatch(txtPostcode.Text, "^[1-9]{4}"))
            {
                err.SetError(txtPostcode, "Dit tekstvak mag alleen getallen bevatten");
                fPost = true;
            }
            else
            {
                err.SetError(txtPostcode, string.Empty);
                fPost = false;
            }
        }

        // De Regex laat alles van (hoofdletter) A-Z 2x toe. Afwijkende invoer is incorrect.
        private void txtPostcode2_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtPostcode2.Text, "^[A-Z][A-Z]$"))
            {
                err.SetError(txtPostcode2, "Dit veld mag alleen (hoofd)letters bevatten");
                fNaam = true;
            }
            else
            {
                err.SetError(txtPostcode2, string.Empty);
                fNaam = false;
            }
        }

        // De Regex laat alles van (hoofdletter) A-Z 2x toe. Afwijkende invoer is incorrect.
        private void txtWoonplaats_Leave(object sender, EventArgs e)
        {
            // De Regex laat alleen hoofdletters, kleine letters en spaties toe. Wanneer er iets anders gezien wordt is de invoer incorrect.
            if (!Regex.IsMatch(txtWoonplaats.Text, "^[a-zA-Z ]*$"))
            {
                err.SetError(txtWoonplaats, "Woonplaats mag alleen hoofdletters, kleine letters en spaties bevatten");
                fCity = true;
            }
            else
            {
                err.SetError(txtWoonplaats, string.Empty);
                fCity = false;
            }
        }

        // Deze is interessant. In plaats van een Regex te gebruiken probeert txtSalaris_Leave de invoer te TryParsen. 
        // Gelukt? Niks aan de hand ('else'). Ging er iets fout? Laat een foutmelding zien ('if') en zet de fault-Boolean "fSalaris" op 'true'.
        private void txtSalaris_Leave(object sender, EventArgs e)
        {
            Single salaparse;
            bool dummy = Single.TryParse(txtSalaris.Text, out salaparse);

            if (!dummy)
            {
                err.SetError(txtSalaris, "Salaris mag alleen getallen bevatten");
                fSalaris = true;
            }
            else
            {
                err.SetError(txtSalaris, string.Empty);
                fSalaris = false;
            }
        }

    }
}
