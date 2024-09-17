while(true) {
Console.WriteLine("välkomen till den rätta vägen");
Console.WriteLine("reglerna är lätta du svarar ja eller nej om inte fråga säger annat förstår du");
string start = Console.ReadLine();
Console.Clear();
if (start == "ja"){
    Console.WriteLine("lycka till");
}
else if (start == "nej") {
    Console.WriteLine("womp womp");
}
Console.WriteLine("tryck på space för att starta");

var startkey = Console.ReadKey(intercept: true);
if(startkey.Key == ConsoleKey.Spacebar){
    Console.Clear();

Console.WriteLine("vill du gå på en promenad (skriv ja/nej)");
string promenad = Console.ReadLine().ToLower();

if (promenad == "ja"){
    Console.Clear();
    Console.WriteLine("du går ut för dörren och när du börjar gå ser du en katt i ett träd vill du rädda katten (skriv ja/nej)");
    string katt = Console.ReadLine().ToLower();
    if (katt == "ja"){
        Console.Clear();
        Console.WriteLine("du klättra upp i trädet och blev klöst av katten och trilla ner och svimma");
    Console.WriteLine("du vaknar upp på sjukhuset och går ur sängen du ser en låda ska du öppna den (skriv ja/nej)");
    string loda = Console.ReadLine().ToLower();
    if (loda == "ja"){
        Console.Clear();
        Console.WriteLine("du öppnar lådan och innuti så finns det en pistol och en kaka vilken väljer du att ta? (skriv pistol/kaka)");
        string ta = Console.ReadLine();
        if (ta == "pistol"){
            Console.Clear();
            Console.WriteLine("du har nu en pistol vill du skjuta dig själv (skriv ja)");
            string dead = Console.ReadLine();
            if (dead == "ja"){
                Console.Clear();
                Console.WriteLine("du dog");
                Console.WriteLine("har du några sista ord");
            }
            
        }
        else if (ta == "kaka"){
            Console.WriteLine("du tar kakan och äter upp den i en stor tugga sen blir du sömnig och går och lägger dig");
        }
    }
            else if (loda == "nej"){
                Console.Clear();
            Console.WriteLine("du öppnade inte lådan och hoppa ut genom fönstret för att hitta revange till katten som gjorde så här mot dig");
        }
}
else if (katt == "nej"){
            Console.WriteLine("du valde att inte rädda katten och fotsatte med promenade, du gick till stranden där du övervägde dina livs val");
        }
}
else if (promenad == "nej") {
    Console.Clear();
    Console.WriteLine("du stannar hemma vill du gå till källaren eller vinden (skriv källare/vinden)");
    string rumm = Console.ReadLine();
    Console.Clear();
    if (rumm == "källaren"){
        Console.WriteLine("du går ner för trappan och det är mörkt och du tänker att elen kanske har gott ska du fortsätta eller gå till elskåpet (skriv elskåp/fortsätt)");
        string el = Console.ReadLine().ToLower();
        Console.Clear();
        if (el == "fortsätt"){
            Console.WriteLine("du fortsätter ner och hittar lamp knappen men den funkar inte och påvägen tillbaka för att sätta på elen så snubblar du på en kabel och slår i huvudet och dör");
        }
        else if (el == "elskåpet"){
            Console.WriteLine("du går till elskåpet och elen sätts på och du går ner till källaren igen där lamporna lyser ska du kolla på tv (skriv ja/nej)");
           string tv = Console.ReadLine();
            Console.Clear();
            if (tv == "ja"){
                Console.WriteLine("du satte dig och började kolla på cocomelon tills din mamma kom hem och natta dig");
            }
            else if (tv =="nej"){
                Console.WriteLine("du  bara står upp och kollar in i väggen tills du somna");
            }


        }

    }
    else if (rumm == "vinden"){
        Console.WriteLine("du går upp för vinden och inser att dörren är låst till den och du vänder dig om för att hämta nyckeln men du ramlar i trappan och bryter nacken");
    }
}
            Console.WriteLine("");
            Console.WriteLine("om du vill starta om skriv ja om du vill stänga av skriv nej");
            string avbryt = Console.ReadLine();
            if(avbryt == "nej"){
                break;
            }
            if (avbryt == "ja"){
                Console.Clear();
            }
}
}