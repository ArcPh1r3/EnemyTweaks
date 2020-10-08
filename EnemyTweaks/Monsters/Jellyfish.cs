using RoR2;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace EnemyTweaks.Monsters
{
    public static class Jellyfish
    {
        public static void Init()
        {
            GameObject characterPrefab = Resources.Load<GameObject>("Prefabs/CharacterBodies/JellyfishBody");
            ItemDisplayRuleSet itemDisplayRuleSet = ScriptableObject.CreateInstance<ItemDisplayRuleSet>();

            List<ItemDisplayRuleSet.NamedRuleGroup> list = new List<ItemDisplayRuleSet.NamedRuleGroup>();
            List<ItemDisplayRuleSet.NamedRuleGroup> list2 = new List<ItemDisplayRuleSet.NamedRuleGroup>();

            ItemDisplayRuleSet original = characterPrefab.GetComponentInChildren<CharacterModel>().itemDisplayRuleSet;

            list2.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "AffixRed",
                displayRuleGroup = original.FindEquipmentDisplayRuleGroup("AffixRed")
            });
            list2.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "AffixBlue",
                displayRuleGroup = original.FindEquipmentDisplayRuleGroup("AffixBlue")
            });
            list2.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "AffixWhite",
                displayRuleGroup = original.FindEquipmentDisplayRuleGroup("AffixWhite")
            });
            list2.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "AffixPoison",
                displayRuleGroup = original.FindEquipmentDisplayRuleGroup("AffixPoison")
            });
            list2.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "AffixHaunted",
                displayRuleGroup = original.FindEquipmentDisplayRuleGroup("AffixHaunted")
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "CritGlasses",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayGlasses"),
                            childName = "Hull2",
                            localPos = new Vector3(0, 1.1f, 0),
                            localAngles = new Vector3(270, 90, 0),
                            localScale = new Vector3(2.8f, 3, 3),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Crowbar",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayCrowbar"),
                            childName = "Hull2",
                            localPos = new Vector3(1, 0, 0),
                            localAngles = new Vector3(0, 0, 0),
                            localScale = new Vector3(2, 2, 2),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Behemoth",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBehemoth"),
                            childName = "Hull2",
                            localPos = new Vector3(0, 0.6f, 1.5f),
                            localAngles = new Vector3(0, 0, 0),
                            localScale = new Vector3(0.3f, 0.3f, 0.3f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "NearbyDamageBonus",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayDiamond"),
                            childName = "Hull2",
                            localPos = new Vector3(0, 0, 0),
                            localAngles = new Vector3(0, 0, 0),
                            localScale = new Vector3(1.5f, 1.5f, 1.5f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "FireRing",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayFireRing"),
                            childName = "Hull2",
                            localPos = new Vector3(0, 0, 0),
                            localAngles = new Vector3(90, 0, 0),
                            localScale = new Vector3(11, 11, 11),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "IceRing",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayIceRing"),
                            childName = "Hull2",
                            localPos = new Vector3(0, 0.5f, 0),
                            localAngles = new Vector3(90, 0, 0),
                            localScale = new Vector3(11, 11, 11),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "ArmorPlate",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayRepulsionArmorPlate"),
                            childName = "Hull2",
                            localPos = new Vector3(-0.3f, 0, 0.65f),
                            localAngles = new Vector3(270, 0, 0),
                            localScale = new Vector3(3, 2, 2),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Bear",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBear"),
                            childName = "Hull2",
                            localPos = new Vector3(0.7f, 0, -0.7f),
                            localAngles = new Vector3(0, 135, 0),
                            localScale = new Vector3(2, 2, 2),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Medkit",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayMedkit"),
                            childName = "Hull2",
                            localPos = new Vector3(-1.25f, 0, 0),
                            localAngles = new Vector3(270, 270, 0),
                            localScale = new Vector3(4, 4, 4),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Dagger",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayDagger"),
                            childName = "Hull2",
                            localPos = new Vector3(0, 0.75f, 0.75f),
                            localAngles = new Vector3(270, 0, 0),
                            localScale = new Vector3(5, 5, 5),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            /*list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "ChainLightning",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayUkulele"),
                            childName = "Hull2",
                            localPos = new Vector3(0.4f, 0, -1.75f),
                            localAngles = new Vector3(0, 85, 90),
                            localScale = new Vector3(0.8f, 0.8f, 0.8f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });*/

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Syringe",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplaySyringeCluster"),
                            childName = "Hull2",
                            localPos = new Vector3(0.5f, 0, 0.5f),
                            localAngles = new Vector3(0, 315, 270),
                            localScale = new Vector3(1, 1, 1),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "UtilitySkillMagazine",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayAfterburnerShoulderRing"),
                            childName = "Hull2",
                            localPos = new Vector3(0, 0.6f, 0),
                            localAngles = new Vector3(0, 0, 0),
                            localScale = new Vector3(4, 4, 4),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Hoof",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayHoof"),
                            childName = "Hull2",
                            localPos = new Vector3(0, -1, 0),
                            localAngles = new Vector3(270, 270, 0),
                            localScale = new Vector3(0.25f, 0.25f, 0.25f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "SprintOutOfCombat",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayWhip"),
                            childName = "Hull2  ",
                            localPos = new Vector3(0, 0, 0),
                            localAngles = new Vector3(0, 0, 90),
                            localScale = new Vector3(3, 3, 3),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            //apply displays here

            BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
            ItemDisplayRuleSet.NamedRuleGroup[] value = list.ToArray();
            ItemDisplayRuleSet.NamedRuleGroup[] value2 = list2.ToArray();
            typeof(ItemDisplayRuleSet).GetField("namedItemRuleGroups", bindingAttr).SetValue(itemDisplayRuleSet, value);
            typeof(ItemDisplayRuleSet).GetField("namedEquipmentRuleGroups", bindingAttr).SetValue(itemDisplayRuleSet, value2);

            characterPrefab.GetComponentInChildren<CharacterModel>().itemDisplayRuleSet = itemDisplayRuleSet;
        }

    }
}
