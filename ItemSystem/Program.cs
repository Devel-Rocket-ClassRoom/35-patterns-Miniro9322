using System;

// README.md를 읽고 코드를 작성하세요.

Console.WriteLine("=== 게임 아이템 시스템 ===");

Item[] items =
{
    new Weapon{Name = "화염검", Rarity = Rarity.Legendary, Damage = 1, WeaponType = WeaponType.Sword},
    new Weapon{Name = "사냥꾼의 활", Rarity = Rarity.Rare, Damage = 45, WeaponType = WeaponType.Bow},
    new Weapon{Name = "화염검", Rarity = Rarity.Legendary, Damage = 1, WeaponType = WeaponType.Sword},
    new Weapon{Name = "화염검", Rarity = Rarity.Legendary, Damage = 1, WeaponType = WeaponType.Sword}
};

int GetItemValue(Rarity rarity) => rarity switch
{

}