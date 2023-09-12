﻿using Microsoft.Xna.Framework;
using Terraria.GameContent.Creative;

namespace Terramon.Content.Items.Mechanical;

internal class PokeBallProjectile : BasePkballProjectile
{
    public override int pokeballCapture => ModContent.ItemType<PokeBallItem>();
    public override float catchModifier => 1;
}

internal class PokeBallItem : BasePkballItem
{
    protected override int UseRarity => ModContent.RarityType<PokeBallRarity>();
    protected override int pokeballThrow => ModContent.ProjectileType<PokeBallProjectile>();
    protected override int igPrice => 200;

    public override void SetStaticDefaults()
    {
        CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] =
            igPrice / 2; //Amount needed to duplicate them in Journey Mode
    }
}

public class PokeBallRarity : ModRarity
{
    public override Color RarityColor => new(214, 74, 86);
}