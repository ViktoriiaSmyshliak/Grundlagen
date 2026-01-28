using Grundlagen.Grundlagen;
using Grundlagen.OOP;
using Grundlagen.OOP.Interfaces;
using Grundlagen.OOP.Models;
using Grundlagen.OOP.Models.Geschaeftsgebaeude;
using Grundlagen.OOP.Models.Wohngebaeude;
using Grundlagen.Services;



Variablen.Run3();

ArrayFields.OneDimensionalArrays();
ArrayFields.MultiDimensionalArrays();
ArrayFields.ArrayProperties();

Enumerations.Months();
Enumerations.Weekdays();
Enumerations.Animals();

ValueAndReferenceTypes.ValueTypes();
ValueAndReferenceTypes.ReferenceTypes();
ValueAndReferenceTypes.Compare();

Strings.StringVsOtherReferenceTypes();
Strings.StringOperations();

DateTimes.DateTimeObjects();
DateTimes.DateTimePropertiesAndMethods();

Branching.IfStatements();
Branching.SwitchStatement();
Branching.SwitchWithCertificate();

Loops.ForLoops();
Loops.ForeachLoop();
Loops.WhileLoop();
Loops.DoWhileLoop();

CollectionClasses.ArrayListTasks();
CollectionClasses.HashtableTasks();

#region OOP
// Wohngebaeude
Gebaeude haus = new Einfamilienhaus(
        gesamtnutzflaecheQm: 140,
        gartenQm: 300,
        miete: 1200,
        einbaukueche: true
    );

    Gebaeude villa = new Villa(
        gesamtnutzflaecheQm: 280,
        gartenQm: 800,
        miete: 3200,
        einliegerwohnung: true
    );

    // Geschaeftsgebaeude
    Gebaeude laden = new Laden(
        gesamtnutzflaecheQm: 90,
        pacht: 1500,
        verkaufsflaecheQm: 70
    );

    Gebaeude restaurant = new Restaurant(
        gesamtnutzflaecheQm: 200,
        pacht: 2800,
        anzahlTische: 25,
        aussenbewirtschaftung: true
    );

    Gebaeude buero = new Buero(
        gesamtnutzflaecheQm: 160,
        pacht: 2100,
        notstromversorgung: false
    );

    // Alle Objekte in einer gemeinsamen Liste
    List<Gebaeude> gebaeudeListe = new()
    {
        haus,
        villa,
        laden,
        restaurant,
        buero
    };

 //restaurant.IsPutzen();
    // Polymorphe mit Abstract Classes
    //foreach (var g in gebaeudeListe)
    //{
    //    Console.WriteLine("-------------");
    //    g.Print();
    //}

     //Polymorphe mit Interfaces

    var list = new List<IPrintable>
    {
        haus,
        villa,
        laden,
        restaurant,
        buero
    };
    //PrintHelper.PrintAll(list);
#endregion

#region Array
    // Array
    
//string[,] table =
//{
//    { "Alaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "B1", "C1", "" },
//    { "A2", "B2ffffffffffff", "C2ssssssss", "1" }
//};

//var printer1 = new TablePrinter(table);
//printer1.Print();


//// Beispiel mit einem Jagged Array (string[][])
//var table2 = new[]
//{
//    new[] { "Alaaaaaaaaaaaaaaaaaaaaaaaaa", "B134534534345345345345", "C1" },
//    new[] { "", "B2345345dgdfdgdgf", "C234535345" }
//};

//var printer2 = new TablePrinter(table2, "x");
//printer2.Print();

#endregion