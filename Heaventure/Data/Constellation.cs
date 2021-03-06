﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace Heaventure.Data
{
    public class Constellation
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string ImageUrl { get; private set; }
        public int StarCount { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public static List<Constellation> All()
        {
            if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "ar")
            {
                return AllArabic();
            }
            else
            {
                return AllEnglish();
            }
        }

        public static Constellation FindById(int id) => 
            All().Find(constellation => constellation.Id == id);

        private static List<Constellation> AllEnglish()
        {
            return new List<Constellation>()
            {
                new Constellation() {
                    Id = 1,
                    Name = "Capricornus",
                    Description = "Capricornus /ˌkæprɪˈkɔːrnəs/ is one of the constellations of the zodiac. Its name is Latin for \"horned goat\" or \"goat horn\" or \"having horns like a goat's\", and it is commonly represented in the form of a sea goat: a mythical creature that is half goat, half fish. Its symbol is (Unicode ♑).",
                    ImageUrl = "~/Content/Images/Capricornus.png",
                    StarCount = 3,
                    CreatedAt = new DateTime(2020, 04, 22)
                },
                new Constellation() {
                    Id = 2,
                    Name = "Aries",
                    Description = "Aries is one of the constellations of the zodiac. It is located in the Northern celestial hemisphere between Pisces to the west and Taurus to the east. The name Aries is Latin for ram, and its symbol is (Unicode ♈), representing a ram's horns.",
                    ImageUrl = "~/Content/Images/Aries.png",
                    StarCount = 18,
                    CreatedAt = new DateTime(2020, 04, 20)
                },
                new Constellation()
                {
                    Id = 3,
                    Name = "Hydrus",
                    Description = "Hydrus /ˈhaɪdrəs/ is a small constellation in the deep southern sky. It was one of twelve constellations created by Petrus Plancius from the observations of Pieter Dirkszoon Keyser and Frederick de Houtman.",
                    ImageUrl = "~/Content/Images/Hydrus.png",
                    StarCount = 18,
                    CreatedAt = new DateTime(2020, 03, 30)
                },
                new Constellation()
                {
                    Id = 4,
                    Name = "Puppis",
                    Description = "Puppis /ˈpʌpɪs/ is a constellation in the southern sky. Puppis, the Poop Deck, was originally part of an over-large constellation, the ship of Jason and the Argonauts, Argo Navis, which centuries after its initial description, was divided into three parts, the other two being Carina (the keel and hull), and Vela (the sails of the ship).",
                    ImageUrl = "~/Content/Images/Puppis.png",
                    StarCount = 9,
                    CreatedAt = new DateTime(2020, 04, 14)
                },
                new Constellation()
                {
                    Id = 5,
                    Name = "Telescopium",
                    Description = "Telescopium is a minor constellation in the southern celestial hemisphere, one of twelve named in the 18th century by French astronomer Nicolas-Louis de Lacaille and one of several depicting scientific instruments. Its name is a Latinized form of the Greek word for telescope.",
                    ImageUrl = "~/Content/Images/Telescopium.png",
                    StarCount = 2,
                    CreatedAt = new DateTime(2020, 04, 19)
                },
                new Constellation()
                {
                    Id = 6,
                    Name = "Ursa Major",
                    Description = "Ursa Major (/ˈɜːrsə ˈmeɪdʒər/; also known as the Great Bear) is a constellation in the northern sky, whose associated mythology likely dates back into prehistory. Its Latin name means \"greater (or larger) she-bear,\" referring to and contrasting it with nearby Ursa Minor, the lesser bear.",
                    ImageUrl = "~/Content/Images/UrsaMajor.png",
                    StarCount = 20,
                    CreatedAt = new DateTime(2020, 03, 21)
                }
            };
        }

        private static List<Constellation> AllArabic()
        {
            return new List<Constellation>()
            {
                new Constellation() {
                    Id = 1,
                    Name = "الجدي",
                    Description = "برج الجدي هو أحد الأبراج البروج. اسمها لاتيني للقرن الماعز أو قرن الماعز أو وجود قرون مثل الماعز ، ويتم تمثيله عادة في شكل ماعز بحري: مخلوق أسطوري نصف ماعز ونصف سمكة. رمزها (Unicode ♑)",
                    ImageUrl = "~/Content/Images/Capricornus.png",
                    StarCount = 3,
                    CreatedAt = new DateTime(2020, 04, 22)
                },
                new Constellation() {
                    Id = 2,
                    Name = "الحمل",
                    Description = "برج الحمل هو أحد الأبراج البروج. تقع في نصف الكرة السماوية الشمالي بين برج الحوت إلى الغرب و برج الثور إلى الشرق. الاسم Aries هو لاتيني للرام ، ورمزه هو (Unicode ♈) ، الذي يمثل قرون الكبش.",
                    ImageUrl = "~/Content/Images/Aries.png",
                    StarCount = 18,
                    CreatedAt = new DateTime(2020, 04, 20)
                },
                new Constellation()
                {
                    Id = 3,
                    Name = "هيدروس",
                    Description = "هيدروس هو كوكبة صغيرة في السماء الجنوبية العميقة. كانت واحدة من اثني عشر كوكبة أنشأها بيتروس بلانسيوس من ملاحظات بيتر ديركزون كيزر وفريدريك دي هوتمان.",
                    ImageUrl = "~/Content/Images/Hydrus.png",
                    StarCount = 18,
                    CreatedAt = new DateTime(2020, 03, 30)
                },
                new Constellation()
                {
                    Id = 4,
                    Name = "بوبيس",
                    Description = "بوبيس هو كوكبة في السماء الجنوبية. كان Puppis ، The Poop Deck ، في الأصل جزءًا من كوكبة كبيرة جدًا ، تم تقسيم سفينة Jason و Argonauts ، Argo Navis ، التي كانت بعد قرون من وصفها الأولي ، إلى ثلاثة أجزاء ، الجزءان الآخران هما Carina (العارضة والبدن) ) وفيلا (أشرعة السفينة).",
                    ImageUrl = "~/Content/Images/Puppis.png",
                    StarCount = 9,
                    CreatedAt = new DateTime(2020, 04, 14)
                },
                new Constellation()
                {
                    Id = 5,
                    Name = "تلسكوبيم",
                    Description = "تلسكوبي هو كوكبة صغيرة في نصف الكرة السماوية الجنوبي ، واحد من اثني عشر اسمه في القرن الثامن عشر من قبل الفلكي الفرنسي نيكولا لويس دي لاكايل وواحدة من عدة أدوات علمية تصور. اسمها هو شكل لاتيني للكلمة اليونانية للتلسكوب.",
                    ImageUrl = "~/Content/Images/Telescopium.png",
                    StarCount = 2,
                    CreatedAt = new DateTime(2020, 04, 19)
                },
                new Constellation()
                {
                    Id = 6,
                    Name = "أورسا ميجور",
                    Description = "أورسا ميجور (المعروف أيضًا باسم الدب الكبير) هو كوكبة في السماء الشمالية ، والتي من المحتمل أن تعود أساطيرها المرتبطة إلى عصور ما قبل التاريخ. اسمها اللاتيني يعني تحملها أكبر (أو أكبر) ، في إشارة إليها ومقارنتها مع Ursa Minor القريبة ، الدب الأصغر.",
                    ImageUrl = "~/Content/Images/UrsaMajor.png",
                    StarCount = 20,
                    CreatedAt = new DateTime(2020, 03, 21)
                }
            };
        }
    }
}