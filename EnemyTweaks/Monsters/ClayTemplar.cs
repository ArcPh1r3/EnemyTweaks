using RoR2;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace EnemyTweaks.Monsters
{
    public static class ClayTemplar
    {
        public static void Init()
        {
            GameObject characterPrefab = Resources.Load<GameObject>("Prefabs/CharacterBodies/ClayBruiserBody");
            ItemDisplayRuleSet itemDisplayRuleSet = ScriptableObject.CreateInstance<ItemDisplayRuleSet>();

            List<ItemDisplayRuleSet.NamedRuleGroup> list = new List<ItemDisplayRuleSet.NamedRuleGroup>();
            List<ItemDisplayRuleSet.NamedRuleGroup> list2 = new List<ItemDisplayRuleSet.NamedRuleGroup>();

            ItemDisplayRuleSet original = characterPrefab.GetComponentInChildren<CharacterModel>().itemDisplayRuleSet;
            ItemDisplayRuleSet loader = Resources.Load<GameObject>("Prefabs/CharacterBodies/LoaderBody").GetComponentInChildren<CharacterModel>().itemDisplayRuleSet;

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
                name = "IncreaseHealing",
                displayRuleGroup = loader.FindItemDisplayRuleGroup("IncreaseHealing")
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "NovaOnHeal",
                displayRuleGroup = loader.FindItemDisplayRuleGroup("NovaOnHeal")
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "KillEliteFrenzy",
                displayRuleGroup = loader.FindItemDisplayRuleGroup("KillEliteFrenzy")
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Clover",
                displayRuleGroup = loader.FindItemDisplayRuleGroup("Clover")
            });

            list2.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Jetpack",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBugWings"),
                            childName = "Head",
                            localPos = new Vector3(-0.15f, -0.25f, 0),
                            localAngles = new Vector3(0, 45, 0),
                            localScale = new Vector3(0.25f, 0.25f, 0.25f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list2.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "GoldGat",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayGoldGat"),
                            childName = "Muzzle",
                            localPos = new Vector3(1, 0.8f, -1),
                            localAngles = new Vector3(45, 90, 0),
                            localScale = new Vector3(0.5f, 0.5f, 0.5f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
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
                            childName = "Head",
                            localPos = new Vector3(0, 0.4f, 0.25f),
                            localAngles = new Vector3(0, 0, 0),
                            localScale = new Vector3(0.5f, 0.5f, 0.5f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "GhostOnKill",
                displayRuleGroup = loader.FindItemDisplayRuleGroup("GhostOnKill")
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "AttackSpeedOnCrit",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayWolfPelt"),
                            childName = "Head",
                            localPos = new Vector3(0, 0.5f, 0.067f),
                            localAngles = new Vector3(0, 0, 0),
                            localScale = new Vector3(1, 1, 1),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "GoldOnHit",
                displayRuleGroup = loader.FindItemDisplayRuleGroup("GoldOnHit")
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "ShieldOnly",
                displayRuleGroup = loader.FindItemDisplayRuleGroup("ShieldOnly")
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "HeadHunter",
                displayRuleGroup = loader.FindItemDisplayRuleGroup("HeadHunter")
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "JumpBoost",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayWaxBird"),
                            childName = "Head",
                            localPos = new Vector3(0, -0.7f, -0.05f),
                            localAngles = new Vector3(0, 0, 0),
                            localScale = new Vector3(2, 2, 2),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Bandolier",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBandolier"),
                            childName = "Muzzle",
                            localPos = new Vector3(0.05f, -0.05f, -1.75f),
                            localAngles = new Vector3(0, 0, 0),
                            localScale = new Vector3(0.75f, 1, 1),
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBandolier"),
                            childName = "Head",
                            localPos = new Vector3(-0.2f, -0.5f, 0.25f),
                            localAngles = new Vector3(-45, 180, 0),
                            localScale = new Vector3(1, 2, 1),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "DeathMark",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayDeathMark"),
                            childName = "Muzzle",
                            localPos = new Vector3(0, 0, -0.25f),
                            localAngles = new Vector3(0, 0, 0),
                            localScale = new Vector3(0.1f, 0.1f, 0.1f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "WarCryOnMultiKill",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayPauldron"),
                            childName = "Head",
                            localPos = new Vector3(0, 0.1f, -0.25f),
                            localAngles = new Vector3(-90, 0, 0),
                            localScale = new Vector3(1.5f, 1.5f, 1.5f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Mushroom",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayMushroom"),
                            childName = "Head",
                            localPos = new Vector3(-0.25f, 0, 0),
                            localAngles = new Vector3(0, 0, 45),
                            localScale = new Vector3(0.25f, 0.25f, 0.25f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "BarrierOnOverHeal",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayAegis"),
                            childName = "Muzzle",
                            localPos = new Vector3(0, 0.25f, -1),
                            localAngles = new Vector3(180, 180, 180),
                            localScale = new Vector3(0.75f, 0.75f, 0.75f),
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
                            childName = "Muzzle",
                            localPos = new Vector3(0, 0, -0.9f),
                            localAngles = new Vector3(90, 0, 0),
                            localScale = new Vector3(0.5f, 0.5f, 0.5f),
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
                            childName = "Muzzle",
                            localPos = new Vector3(0, 0, -2.75f),
                            localAngles = new Vector3(0, 0, 0),
                            localScale = new Vector3(0.7f, 0.7f, 0.7f),
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
                            childName = "Muzzle",
                            localPos = new Vector3(0, 0, -1),
                            localAngles = new Vector3(0, 0, 0),
                            localScale = new Vector3(3.5f, 3.5f, 3.5f),
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
                            childName = "Muzzle",
                            localPos = new Vector3(0, 0, -1.2f),
                            localAngles = new Vector3(0, 0, 0),
                            localScale = new Vector3(3.5f, 3.5f, 3.5f),
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
                            childName = "Head",
                            localPos = new Vector3(-0.4f, -0.5f, 0.15f),
                            localAngles = new Vector3(-90, 260, 45),
                            localScale = new Vector3(0.8f, 0.6f, 0.6f),
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
                            childName = "Head",
                            localPos = new Vector3(0, 0, -0.4f),
                            localAngles = new Vector3(0, 180, 0),
                            localScale = new Vector3(0.6f, 0.6f, 0.6f),
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
                            childName = "Head",
                            localPos = new Vector3(-0.4f, -0.5f, 0.15f),
                            localAngles = new Vector3(-90, -90, 0),
                            localScale = new Vector3(1.5f, 1.5f, 1.5f),
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
                            childName = "Head",
                            localPos = new Vector3(0, 0, 0),
                            localAngles = new Vector3(-90, -90, 0),
                            localScale = new Vector3(2, 2, 2),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
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
                            childName = "Muzzle",
                            localPos = new Vector3(0.4f, 0, -1.75f),
                            localAngles = new Vector3(0, 85, 90),
                            localScale = new Vector3(0.8f, 0.8f, 0.8f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

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
                            childName = "Head",
                            localPos = new Vector3(0, 0, -0.15f),
                            localAngles = new Vector3(-60, 0, 0),
                            localScale = new Vector3(0.5f, 0.5f, 0.5f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "ArmorReductionOnHit",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayWarhammer"),
                            childName = "Muzzle",
                            localPos = new Vector3(0, 0.25f, 0),
                            localAngles = new Vector3(0, 0, 0),
                            localScale = new Vector3(1, 1, 1),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "FallBoots",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayGravBoots"),
                            childName = "FootL",
                            localPos = new Vector3(0, -0.05f, 0),
                            localAngles = new Vector3(45, 0, 0),
                            localScale = new Vector3(0.25f, 0.25f, 0.25f),
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayGravBoots"),
                            childName = "FootR",
                            localPos = new Vector3(0, -0.05f, 0),
                            localAngles = new Vector3(70, 0, 0),
                            localScale = new Vector3(0.25f, 0.25f, 0.25f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "BounceNearby",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayHook"),
                            childName = "Muzzle",
                            localPos = new Vector3(0, 0, -0.25f),
                            localAngles = new Vector3(0, 0, 0),
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
                            childName = "Muzzle",
                            localPos = new Vector3(0, 0, -0.75f),
                            localAngles = new Vector3(0, -90, 90),
                            localScale = new Vector3(2, 2, 2),
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
                            childName = "FootL",
                            localPos = new Vector3(0, 0.05f, -0.15f),
                            localAngles = new Vector3(50, 180, 180),
                            localScale = new Vector3(0.15f, 0.15f, 0.075f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "HealWhileSafe",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplaySnail"),
                            childName = "FootR",
                            localPos = new Vector3(0, -0.05f, 0),
                            localAngles = new Vector3(0, 0, 180),
                            localScale = new Vector3(0.1f, 0.1f, 0.1f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "LunarPrimaryReplacement",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBirdEye"),
                            childName = "Muzzle",
                            localPos = new Vector3(0, -0.1f, -0.25f),
                            localAngles = new Vector3(-90, 0, 0),
                            localScale = new Vector3(1, 1, 1),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "SecondarySkillMagazine",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayDoubleMag"),
                            childName = "Muzzle",
                            localPos = new Vector3(0, -0.8f, -2),
                            localAngles = new Vector3(0, 0, 0),
                            localScale = new Vector3(-0.2f, -0.2f, -0.2f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Pearl",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayPearl"),
                            childName = "Head",
                            localPos = new Vector3(-1, 0, 0),
                            localAngles = new Vector3(0, 0, 0),
                            localScale = new Vector3(0.2f, 0.2f, 0.2f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "ShinyPearl",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayShinyPearl"),
                            childName = "Head",
                            localPos = new Vector3(1, 0, 0),
                            localAngles = new Vector3(0, 0, 0),
                            localScale = new Vector3(0.2f, 0.2f, 0.2f),
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
                            childName = "Head",
                            localPos = new Vector3(-0.5f, -1.2f, 0.25f),
                            localAngles = new Vector3(0, 0, -20),
                            localScale = new Vector3(1, 1, 1),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list2.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Fruit",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayFruit"),
                            childName = "Head",
                            localPos = new Vector3(0.6f, -1.2f, 0),
                            localAngles = new Vector3(0, -45, 45),
                            localScale = new Vector3(0.75f, 0.75f, 0.75f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list2.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "BFG",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBFG"),
                            childName = "Muzzle",
                            localPos = new Vector3(0, 0.2f, -0.25f),
                            localAngles = new Vector3(0, 0, 0),
                            localScale = new Vector3(0.75f, 0.75f, 0.75f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            //follower prefabs

            list2.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Meteor",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayMeteor"),
                            childName = "Root",
                            localPos = new Vector3(0, 2, -0.75f),
                            localAngles = new Vector3(0, 0, 0),
                            localScale = new Vector3(2, 2, 2),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            /*list2.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Saw",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplaySawmerang"),
                            childName = "Root",
                            localPos = new Vector3(0, 2, -0.75f),
                            localAngles = new Vector3(-90, 0, 0),
                            localScale = new Vector3(0.4f, 0.4f, 0.4f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });*/

            list2.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Blackhole",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayGravCube"),
                            childName = "Root",
                            localPos = new Vector3(0, 2, -0.75f),
                            localAngles = new Vector3(0, 0, 0),
                            localScale = new Vector3(1, 1, 1),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Icicle",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayFrostRelic"),
                            childName = "Root",
                            localPos = new Vector3(-1, 2, -1),
                            localAngles = new Vector3(90, 0, 0),
                            localScale = new Vector3(2, 2, 2),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Talisman",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayTalisman"),
                            childName = "Root",
                            localPos = new Vector3(1, 2, -1),
                            localAngles = new Vector3(0, 0, 0),
                            localScale = new Vector3(1, 1, 1),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "FocusConvergence",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayFocusedConvergence"),
                            childName = "Root",
                            localPos = new Vector3(0.5f, 2.5f, -3),
                            localAngles = new Vector3(0, 0, 0),
                            localScale = new Vector3(0.2f, 0.2f, 0.2f),
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
