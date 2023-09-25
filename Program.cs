using System;
using System.Collections.Generic;
using System.Linq;
using DebtorsHW.Models;

class Program
{
    static void Main()
    {
        var debtors = Debtor.getdebtors();

        //2) rhyta.com ve ya dayrep.com domenlerinde emaili olan borclulari cixartmag
        //debtors.FindAll(d => d.Email.EndsWith("rhyta.com") || d.Email.EndsWith("dayrep.com") && d.Debt > 0).Select(d => d.FullName).Print();

        //3) Yashi 26-dan 36-ya qeder olan borclulari cixartmag 
        //debtors.FindAll(d => d.BirthDay.Year > 1997 && d.BirthDay.Year > 1997 && d.Debt > 0).Select(d => d.FullName).Print();

        //4) Borcu 5000 - den cox olmayan borclularic cixartmag
        //debtors.FindAll(d => d.Debt < 5000).Select(d => d.FullName).Print();

        //5) Butov adi 18 simvoldan cox olan ve telefon nomresinde 2 ve ya 2 - den cox 7 reqemi olan borclulari cixartmaq
        //debtors.FindAll(d => d.FullName.Length > 18).Select(d => d.FullName).Print();

        //7) Qishda anadan olan borclulari cixardmaq
        //debtors.FindAll(d => d.BirthDay.Month == 1 || d.BirthDay.Month == 2 || d.BirthDay.Month == 12 && d.Debt > 0).Select(d => d.FullName).Print();

        //8) Borcu, umumi borclarin orta borcunnan cox olan borclulari cixarmaq ve evvel familyaya gore sonra ise meblegin azalmagina gore sortirovka etmek
        //var sum = debtors.Sum(d => d.Debt);
        //var count = debtors.Count();
        //debtors.FindAll(d => d.Debt > (sum / count)).Select(d => d.FullName).Print();

        //9) Telefon nomresinde 8 olmayan borclularin yalniz familyasin, yashin ve umumi borcun meblegin cixarmaq
        //debtors.Where(d => !d.Phone.Contains("8")).Select(d => d.FullName).Print();

        //11) Adinda ve familyasinda hec olmasa 3 eyni herf olan borclularin siyahisin cixarmaq ve onlari elifba sirasina gore sortirovka elemek
        //debtors.FindAll(d => d.FullName.Distinct().Count() >= 3).OrderBy(d => d.FullName).Select(d => $"{d.FullName}").Print();

        //13) borclulardan en coxu hansi ilde dogulubsa hemin ili cixartmaq
        //debtors.OrderByDescending(d => d.BirthDay.Month).Select(d => d.BirthDay.Month).Print();
        //foreach (var d in debtors.FindAll(d => d.BirthDay.Year == debtors.GroupBy(d => d.BirthDay.Year).OrderByDescending(d => d.Count()).Select(d => d.Key).First()))
        //    Console.WriteLine(d);

        //14) Borcu en boyuk olan 5 borclunun siyahisini cixartmaq
        //int c = 1;
        //debtors.OrderByDescending(d => d.Debt).Select(d => $"{c++}){d.FullName}\t-{d.Debt}").Take(5).Print();

        //15) Butun borcu olanlarin borcunu cemleyib umumi borcu cixartmaq
        //Console.WriteLine(debtors.FindAll(d => d.Debt > 0).Sum(d => d.Debt));

        //16) 2ci dunya muharibesin gormush borclularin siyahisi cixartmaq
        //debtors.FindAll(d => d.BirthDay.Year >= 1941 && d.BirthDay.Year <= 1945 ).Select( d => d.FullName).Print();

        //18) Nomresinde tekrar reqemler olmayan borclularin ve onlarin borcunun meblegin cixartmaq
        //debtors.FindAll(d => d.Phone.Distinct().Count() > 0).OrderBy(d => d.Phone).Select(d => $"{d.FullName} -- {d.Phone}").Print();

        //19) Tesevvur edek ki,butun borclari olanlar bugunden etibaren her ay 500 azn pul odeyecekler.Oz ad gunune kimi borcun oduyub qurtara bilenlerin siyahisin cixartmaq
        //debtors.FindAll(d => ((d.BirthDay.Month - 1) * 500 > d.Debt)).Select(d => $"{d.FullName} -- {d.BirthDay} -- {d.Debt}").Print();

        //20) Adindaki ve familyasindaki herflerden "smile" sozunu yaza bileceyimiz borclularin siyahisini cixartmaq
        //debtors.FindAll(s => s.FullName.Contains('s') && s.FullName.Contains('m') && s.FullName.Contains('i') && s.FullName.Contains('l') && s.FullName.Contains('e'))
        //   .Select(d => d.FullName).Print();
    }
}