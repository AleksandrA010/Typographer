using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Typographer.Tests
{
    [TestClass]
    public class TypographerTest
    {

        [TestMethod]
        public void RemoveDoubleSpaceTest()
        {
            string startText = "Сегодня утром я закупилась свежим   молоком в местном магазине, " +
                "чтобы приготовить   вкусный завтрак для своей семьи.";
            string correctText = "Сегодня утром я закупилась свежим молоком в местном магазине, " +
                "чтобы приготовить вкусный завтрак для своей семьи.";

            string resultText = startText;
            resultText = resultText.Replace("  ", " ");
            resultText = resultText.Replace("  ", " ");

            Assert.AreEqual(correctText.Length, resultText.Length);
        }
    }
}
