// <auto-generated> This file has been auto generated. </auto-generated>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;
#if!GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
using Newtonsoft.Json;
#endif

namespace STRATZ
{
    public partial class ItemStatTypeQueryBuilder : GraphQlQueryBuilder<ItemStatTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "behavior", IsComplex = true },
                new FieldMetadata { Name = "unitTargetType", IsComplex = true },
                new FieldMetadata { Name = "unitTargetTeam", IsComplex = true },
                new FieldMetadata { Name = "unitTargetFlags", IsComplex = true },
                new FieldMetadata { Name = "fightRecapLevel", IsComplex = true },
                new FieldMetadata { Name = "castRange", IsComplex = true },
                new FieldMetadata { Name = "castPoint", IsComplex = true },
                new FieldMetadata { Name = "cooldown", IsComplex = true },
                new FieldMetadata { Name = "manaCost", IsComplex = true },
                new FieldMetadata { Name = "channelTime", IsComplex = true },
                new FieldMetadata { Name = "sharedCooldown" },
                new FieldMetadata { Name = "cost" },
                new FieldMetadata { Name = "shopTags" },
                new FieldMetadata { Name = "aliases" },
                new FieldMetadata { Name = "quality" },
                new FieldMetadata { Name = "isSellable" },
                new FieldMetadata { Name = "isDroppable" },
                new FieldMetadata { Name = "isPurchasable" },
                new FieldMetadata { Name = "isSideShop" },
                new FieldMetadata { Name = "isStackable" },
                new FieldMetadata { Name = "isPermanent" },
                new FieldMetadata { Name = "isHideCharges" },
                new FieldMetadata { Name = "isRequiresCharges" },
                new FieldMetadata { Name = "isDisplayCharges" },
                new FieldMetadata { Name = "isSupport" },
                new FieldMetadata { Name = "isAlertable" },
                new FieldMetadata { Name = "isTempestDoubleClonable" },
                new FieldMetadata { Name = "stockMax", IsComplex = true },
                new FieldMetadata { Name = "initialCharges", IsComplex = true },
                new FieldMetadata { Name = "initialStock", IsComplex = true },
                new FieldMetadata { Name = "stockTime" },
                new FieldMetadata { Name = "initialStockTime", IsComplex = true },
                new FieldMetadata { Name = "isRecipe" },
                new FieldMetadata { Name = "needsComponents" },
                new FieldMetadata { Name = "upgradeItem", IsComplex = true },
                new FieldMetadata { Name = "upgradeRecipe", IsComplex = true },
                new FieldMetadata { Name = "itemResult", IsComplex = true },
                new FieldMetadata { Name = "neutralItemDropTime", IsComplex = true },
                new FieldMetadata { Name = "neutralItemTier" }
            };

        protected override string TypeName { get { return "ItemStatType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public ItemStatTypeQueryBuilder WithBehavior(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("behavior", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptBehavior()
        {
            return ExceptField("behavior");
        }

        public ItemStatTypeQueryBuilder WithUnitTargetType(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("unitTargetType", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptUnitTargetType()
        {
            return ExceptField("unitTargetType");
        }

        public ItemStatTypeQueryBuilder WithUnitTargetTeam(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("unitTargetTeam", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptUnitTargetTeam()
        {
            return ExceptField("unitTargetTeam");
        }

        public ItemStatTypeQueryBuilder WithUnitTargetFlags(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("unitTargetFlags", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptUnitTargetFlags()
        {
            return ExceptField("unitTargetFlags");
        }

        public ItemStatTypeQueryBuilder WithFightRecapLevel(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("fightRecapLevel", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptFightRecapLevel()
        {
            return ExceptField("fightRecapLevel");
        }

        public ItemStatTypeQueryBuilder WithCastRange(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("castRange", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptCastRange()
        {
            return ExceptField("castRange");
        }

        public ItemStatTypeQueryBuilder WithCastPoint(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("castPoint", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptCastPoint()
        {
            return ExceptField("castPoint");
        }

        public ItemStatTypeQueryBuilder WithCooldown(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("cooldown", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptCooldown()
        {
            return ExceptField("cooldown");
        }

        public ItemStatTypeQueryBuilder WithManaCost(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("manaCost", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptManaCost()
        {
            return ExceptField("manaCost");
        }

        public ItemStatTypeQueryBuilder WithChannelTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("channelTime", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptChannelTime()
        {
            return ExceptField("channelTime");
        }

        public ItemStatTypeQueryBuilder WithSharedCooldown(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("sharedCooldown", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptSharedCooldown()
        {
            return ExceptField("sharedCooldown");
        }

        public ItemStatTypeQueryBuilder WithCost(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("cost", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptCost()
        {
            return ExceptField("cost");
        }

        public ItemStatTypeQueryBuilder WithShopTags(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("shopTags", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptShopTags()
        {
            return ExceptField("shopTags");
        }

        public ItemStatTypeQueryBuilder WithAliases(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("aliases", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptAliases()
        {
            return ExceptField("aliases");
        }

        public ItemStatTypeQueryBuilder WithQuality(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("quality", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptQuality()
        {
            return ExceptField("quality");
        }

        public ItemStatTypeQueryBuilder WithIsSellable(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isSellable", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptIsSellable()
        {
            return ExceptField("isSellable");
        }

        public ItemStatTypeQueryBuilder WithIsDroppable(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isDroppable", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptIsDroppable()
        {
            return ExceptField("isDroppable");
        }

        public ItemStatTypeQueryBuilder WithIsPurchasable(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isPurchasable", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptIsPurchasable()
        {
            return ExceptField("isPurchasable");
        }

        public ItemStatTypeQueryBuilder WithIsSideShop(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isSideShop", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptIsSideShop()
        {
            return ExceptField("isSideShop");
        }

        public ItemStatTypeQueryBuilder WithIsStackable(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isStackable", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptIsStackable()
        {
            return ExceptField("isStackable");
        }

        public ItemStatTypeQueryBuilder WithIsPermanent(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isPermanent", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptIsPermanent()
        {
            return ExceptField("isPermanent");
        }

        public ItemStatTypeQueryBuilder WithIsHideCharges(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isHideCharges", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptIsHideCharges()
        {
            return ExceptField("isHideCharges");
        }

        public ItemStatTypeQueryBuilder WithIsRequiresCharges(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isRequiresCharges", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptIsRequiresCharges()
        {
            return ExceptField("isRequiresCharges");
        }

        public ItemStatTypeQueryBuilder WithIsDisplayCharges(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isDisplayCharges", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptIsDisplayCharges()
        {
            return ExceptField("isDisplayCharges");
        }

        public ItemStatTypeQueryBuilder WithIsSupport(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isSupport", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptIsSupport()
        {
            return ExceptField("isSupport");
        }

        public ItemStatTypeQueryBuilder WithIsAlertable(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isAlertable", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptIsAlertable()
        {
            return ExceptField("isAlertable");
        }

        public ItemStatTypeQueryBuilder WithIsTempestDoubleClonable(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isTempestDoubleClonable", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptIsTempestDoubleClonable()
        {
            return ExceptField("isTempestDoubleClonable");
        }

        public ItemStatTypeQueryBuilder WithStockMax(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("stockMax", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptStockMax()
        {
            return ExceptField("stockMax");
        }

        public ItemStatTypeQueryBuilder WithInitialCharges(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("initialCharges", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptInitialCharges()
        {
            return ExceptField("initialCharges");
        }

        public ItemStatTypeQueryBuilder WithInitialStock(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("initialStock", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptInitialStock()
        {
            return ExceptField("initialStock");
        }

        public ItemStatTypeQueryBuilder WithStockTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("stockTime", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptStockTime()
        {
            return ExceptField("stockTime");
        }

        public ItemStatTypeQueryBuilder WithInitialStockTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("initialStockTime", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptInitialStockTime()
        {
            return ExceptField("initialStockTime");
        }

        public ItemStatTypeQueryBuilder WithIsRecipe(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isRecipe", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptIsRecipe()
        {
            return ExceptField("isRecipe");
        }

        public ItemStatTypeQueryBuilder WithNeedsComponents(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("needsComponents", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptNeedsComponents()
        {
            return ExceptField("needsComponents");
        }

        public ItemStatTypeQueryBuilder WithUpgradeItem(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("upgradeItem", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptUpgradeItem()
        {
            return ExceptField("upgradeItem");
        }

        public ItemStatTypeQueryBuilder WithUpgradeRecipe(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("upgradeRecipe", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptUpgradeRecipe()
        {
            return ExceptField("upgradeRecipe");
        }

        public ItemStatTypeQueryBuilder WithItemResult(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("itemResult", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptItemResult()
        {
            return ExceptField("itemResult");
        }

        public ItemStatTypeQueryBuilder WithNeutralItemDropTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("neutralItemDropTime", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptNeutralItemDropTime()
        {
            return ExceptField("neutralItemDropTime");
        }

        public ItemStatTypeQueryBuilder WithNeutralItemTier(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("neutralItemTier", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemStatTypeQueryBuilder ExceptNeutralItemTier()
        {
            return ExceptField("neutralItemTier");
        }
    }
}
