using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace DjamUtility.Content;

public class RecipeGroups : ModSystem
{
    public static RecipeGroup IronBars;

    public static RecipeGroup DemoniteBars;

    public static RecipeGroup SilverBars;

    public static RecipeGroup GoldBars;

    public static RecipeGroup EvilComponent;

    public override void Unload()
    {
        EvilComponent = null;
        SilverBars = null;
        DemoniteBars = null;
        IronBars = null;
        GoldBars = null;
    }

    public override void AddRecipeGroups()
    {
        //IL_0032: Unknown result type (might be due to invalid IL or missing references)
        //IL_003c: Expected O, but got Unknown
        //IL_006e: Unknown result type (might be due to invalid IL or missing references)
        //IL_0078: Expected O, but got Unknown
        //IL_00aa: Unknown result type (might be due to invalid IL or missing references)
        //IL_00b4: Expected O, but got Unknown
        //IL_00e6: Unknown result type (might be due to invalid IL or missing references)
        //IL_00f0: Expected O, but got Unknown
        //IL_0122: Unknown result type (might be due to invalid IL or missing references)
        //IL_012c: Expected O, but got Unknown
        EvilComponent = new RecipeGroup((Func<string>)(() => Language.GetTextValue("LegacyMisc.37") + " " + Lang.GetItemNameValue(69)), new int[2] { 69, 1330 });
        GoldBars = new RecipeGroup((Func<string>)(() => Language.GetTextValue("LegacyMisc.37") + " " + Lang.GetItemNameValue(19)), new int[2] { 19, 706 });
        SilverBars = new RecipeGroup((Func<string>)(() => Language.GetTextValue("LegacyMisc.37") + " " + Lang.GetItemNameValue(21)), new int[2] { 21, 705 });
        IronBars = new RecipeGroup((Func<string>)(() => Language.GetTextValue("LegacyMisc.37") + " " + Lang.GetItemNameValue(22)), new int[2] { 22, 704 });
        DemoniteBars = new RecipeGroup((Func<string>)(() => Language.GetTextValue("LegacyMisc.37") + " " + Lang.GetItemNameValue(57)), new int[2] { 57, 1257 });
        RecipeGroup.RegisterGroup("DjamUtility:WormTooth", EvilComponent);
        RecipeGroup.RegisterGroup("DjamUtility:IronBars", IronBars);
        RecipeGroup.RegisterGroup("DjamUtility:DemoniteBars", DemoniteBars);
        RecipeGroup.RegisterGroup("DjamUtility:SilverBars", SilverBars);
        RecipeGroup.RegisterGroup("DjamUtility:GoldBars", GoldBars);
    }
}
