using Xunit;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

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
                            item => Assert.IsAssignableFrom<DragonbornWaffleFries>(item),
                            item => Assert.IsAssignableFrom<DragonbornWaffleFries>(item),

                            item => Assert.IsAssignableFrom<FriedMiraak>(item),
                            item => Assert.IsAssignableFrom<FriedMiraak>(item),
                            item => Assert.IsAssignableFrom<FriedMiraak>(item),

                            item => Assert.IsAssignableFrom<MadOtarGrits>(item),
                            item => Assert.IsAssignableFrom<MadOtarGrits>(item),
                            item => Assert.IsAssignableFrom<MadOtarGrits>(item),

                            item => Assert.IsAssignableFrom<VokunSalad>(item),
                            item => Assert.IsAssignableFrom<VokunSalad>(item),
                            item => Assert.IsAssignableFrom<VokunSalad>(item),


                            item => Assert.IsAssignableFrom<AretinoAppleJuice>(item),
                            item => Assert.IsAssignableFrom<AretinoAppleJuice>(item),
                            item => Assert.IsAssignableFrom<AretinoAppleJuice>(item),

                            item => Assert.IsAssignableFrom<CandlehearthCoffee>(item),
                            item => Assert.IsAssignableFrom<CandlehearthCoffee>(item),
                            item => Assert.IsAssignableFrom<CandlehearthCoffee>(item),

                            item => Assert.IsAssignableFrom<MarkarthMilk>(item),
                            item => Assert.IsAssignableFrom<MarkarthMilk>(item),
                            item => Assert.IsAssignableFrom<MarkarthMilk>(item),

                            item => Assert.IsAssignableFrom<WarriorWater>(item),
                            item => Assert.IsAssignableFrom<WarriorWater>(item),
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

        [Fact]
        public void ItemsShouldStartInInInitialState()
        {
            IEnumerable<IOrderItem> fullmenu = Menu.FullMenu();
            Assert.Collection(fullmenu,
                            item => Assert.IsAssignableFrom<BriarheartBurger>(item),
                            item => Assert.IsAssignableFrom<DoubleDraugr>(item),
                            item => Assert.IsAssignableFrom<GardenOrcOmelette>(item),
                            item => Assert.IsAssignableFrom<PhillyPoacher>(item),
                            item => Assert.IsAssignableFrom<SmokehouseSkeleton>(item),
                            item => Assert.IsAssignableFrom<ThalmorTriple>(item),
                            item => Assert.IsAssignableFrom<ThugsTBone>(item),

                            item => Assert.Equal("Small Dragonborn Waffle Fries", item.ToString()),
                            item => Assert.Equal("Medium Dragonborn Waffle Fries", item.ToString()),
                            item => Assert.Equal("Large Dragonborn Waffle Fries", item.ToString()),

                            item => Assert.Equal("Small Fried Miraak", item.ToString()),
                            item => Assert.Equal("Medium Fried Miraak", item.ToString()),
                            item => Assert.Equal("Large Fried Miraak", item.ToString()),

                            item => Assert.Equal("Small Mad Otar Grits", item.ToString()),
                            item => Assert.Equal("Medium Mad Otar Grits", item.ToString()),
                            item => Assert.Equal("Large Mad Otar Grits", item.ToString()),

                            item => Assert.Equal("Small Vokun Salad", item.ToString()),
                            item => Assert.Equal("Medium Vokun Salad", item.ToString()),
                            item => Assert.Equal("Large Vokun Salad", item.ToString()),

                            item => Assert.Equal("Small Aretino Apple Juice", item.ToString()),
                            item => Assert.Equal("Medium Aretino Apple Juice", item.ToString()),
                            item => Assert.Equal("Large Aretino Apple Juice", item.ToString()),

                            item => Assert.Equal("Small Candlehearth Coffee", item.ToString()),
                            item => Assert.Equal("Medium Candlehearth Coffee", item.ToString()),
                            item => Assert.Equal("Large Candlehearth Coffee", item.ToString()),

                            item => Assert.Equal("Small Markarth Milk", item.ToString()),
                            item => Assert.Equal("Medium Markarth Milk", item.ToString()),
                            item => Assert.Equal("Large Markarth Milk", item.ToString()),

                            item => Assert.Equal("Small Warrior Water", item.ToString()),
                            item => Assert.Equal("Medium Warrior Water", item.ToString()),
                            item => Assert.Equal("Large Warrior Water", item.ToString()),

                            item => Assert.Equal("Small Blackberry Sailor Soda", item.ToString()),
                            item => Assert.Equal("Medium Blackberry Sailor Soda", item.ToString()),
                            item => Assert.Equal("Large Blackberry Sailor Soda", item.ToString()),

                            item => Assert.Equal("Small Cherry Sailor Soda", item.ToString()),
                            item => Assert.Equal("Medium Cherry Sailor Soda", item.ToString()),
                            item => Assert.Equal("Large Cherry Sailor Soda", item.ToString()),

                            item => Assert.Equal("Small Grapefruit Sailor Soda", item.ToString()),
                            item => Assert.Equal("Medium Grapefruit Sailor Soda", item.ToString()),
                            item => Assert.Equal("Large Grapefruit Sailor Soda", item.ToString()),

                            item => Assert.Equal("Small Lemon Sailor Soda", item.ToString()),
                            item => Assert.Equal("Medium Lemon Sailor Soda", item.ToString()),
                            item => Assert.Equal("Large Lemon Sailor Soda", item.ToString()),

                            item => Assert.Equal("Small Peach Sailor Soda", item.ToString()),
                            item => Assert.Equal("Medium Peach Sailor Soda", item.ToString()),
                            item => Assert.Equal("Large Peach Sailor Soda", item.ToString()),

                            item => Assert.Equal("Small Watermelon Sailor Soda", item.ToString()),
                            item => Assert.Equal("Medium Watermelon Sailor Soda", item.ToString()),
                            item => Assert.Equal("Large Watermelon Sailor Soda", item.ToString()));

        }
    }
}
