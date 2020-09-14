using Xunit;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void FullMenuShouldContainAllItems()
        {
            Assert.Collection(Menu.FullMenu(),
                            item => Assert.IsAssignableFrom<BriarheartBurger>(item),
                            item => Assert.IsAssignableFrom<DoubleDraugr>(item),
                            item => Assert.IsAssignableFrom<GardenOrcOmelette>(item),
                            item => Assert.IsAssignableFrom<PhillyPoacher>(item),
                            item => Assert.IsAssignableFrom<SmokehouseSkeleton>(item),
                            item => Assert.IsAssignableFrom<ThalmorTriple>(item),
                            item => Assert.IsAssignableFrom<ThugsTBone>(item),
                            item => Assert.IsAssignableFrom<DragonbornWaffleFries>(item),
                            item => Assert.IsAssignableFrom<FriedMiraak>(item),
                            item => Assert.IsAssignableFrom<MadOtarGrits>(item),
                            item => Assert.IsAssignableFrom<VokunSalad>(item),

                            item => Assert.IsAssignableFrom<AretinoAppleJuice>(item),
                            item => Assert.IsAssignableFrom<CandlehearthCoffee>(item),
                            item => Assert.IsAssignableFrom<MarkarthMilk>(item),
                            item => Assert.IsAssignableFrom<WarriorWater>(item),

                            item => Assert.IsAssignableFrom<AretinoAppleJuice>(item),
                            item => Assert.IsAssignableFrom<CandlehearthCoffee>(item),
                            item => Assert.IsAssignableFrom<MarkarthMilk>(item),
                            item => Assert.IsAssignableFrom<WarriorWater>(item),

                            item => Assert.IsAssignableFrom<AretinoAppleJuice>(item),
                            item => Assert.IsAssignableFrom<CandlehearthCoffee>(item),
                            item => Assert.IsAssignableFrom<MarkarthMilk>(item),
                            item => Assert.IsAssignableFrom<WarriorWater>(item),


                            item => Assert.IsAssignableFrom<SailorSoda>(item),
                            item => Assert.IsAssignableFrom<SailorSoda>(item),
                            item => Assert.IsAssignableFrom<SailorSoda>(item),

                            item => Assert.IsAssignableFrom<SailorSoda>(item),
                            item => Assert.IsAssignableFrom<SailorSoda>(item),
                            item => Assert.IsAssignableFrom<SailorSoda>(item),

                            item => Assert.IsAssignableFrom<SailorSoda>(item),
                            item => Assert.IsAssignableFrom<SailorSoda>(item),
                            item => Assert.IsAssignableFrom<SailorSoda>(item),

                            item => Assert.IsAssignableFrom<SailorSoda>(item),
                            item => Assert.IsAssignableFrom<SailorSoda>(item),
                            item => Assert.IsAssignableFrom<SailorSoda>(item),

                            item => Assert.IsAssignableFrom<SailorSoda>(item),
                            item => Assert.IsAssignableFrom<SailorSoda>(item),
                            item => Assert.IsAssignableFrom<SailorSoda>(item),

                            item => Assert.IsAssignableFrom<SailorSoda>(item),
                            item => Assert.IsAssignableFrom<SailorSoda>(item),
                            item => Assert.IsAssignableFrom<SailorSoda>(item));

        }
    }
}
