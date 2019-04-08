using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using MathHammer.src.ArmyHierarchy;

namespace MathHammer.src
{
    /// <summary>
    /// Handles parsing and interpreting the battlescribe xml files
    /// </summary>
    public static class XmlHandler
    {

        internal static ArmyList AttackingArmyList;
        internal static ArmyList DefendingArmyList;

        private static XmlDocument _attackingArmy;
        private static XmlDocument _defendingArmy;

        private static ArmyListAllegiance _currAllegiance;

        private static string _attackingArmyPath;
        private static string _defendingArmyPath;

        private static void OpenDocument(string path, ArmyListAllegiance aLa)
        {

            // loads the .ros into the attacking or defending variable
            try
            {
                switch (aLa)
                {
                    case ArmyListAllegiance.Attacking:
                        _attackingArmy = new XmlDocument();
                        _attackingArmyPath = path;
                        _attackingArmy.Load(path);
                        break;
                    case ArmyListAllegiance.Defending:
                        _defendingArmy = new XmlDocument();
                        _defendingArmyPath = path;
                        _defendingArmy.Load(path);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(aLa), aLa, null);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not load file.\n\n" + 
                    "Error message:\n" +
                    e.Message + "\n\n" +
                    "Stacktrace:\n" +
                    e.ToString(), "ERROR");
            }
        }

        public static void CloseDocument(ArmyListAllegiance aLa)
        {
            switch (aLa)
            {
                case ArmyListAllegiance.Attacking:
                    _attackingArmy = null;
                    break;
                case ArmyListAllegiance.Defending:
                    _defendingArmy = null;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(aLa), aLa, null);
            }
            GC.Collect();
        }

        /// <summary>
        /// Prompts user with file dialogue and form 
        /// </summary>
        public static void OpenDocumentPrompt()
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Title = "Select attacking / defending army roster file",
                Filter = "Raw Roster File (*.ros)|*.ros"
            };

            if (DialogResult.OK == dialog.ShowDialog())
            {
                DocumentSelectionForm docSelect = new DocumentSelectionForm();
                docSelect.ShowDialog();

                switch (_currAllegiance)
                {
                    case ArmyListAllegiance.Attacking:
                        OpenDocument(Path.GetFullPath(dialog.FileName), ArmyListAllegiance.Attacking);
                        break;
                    case ArmyListAllegiance.Defending:
                        OpenDocument(Path.GetFullPath(dialog.FileName), ArmyListAllegiance.Defending);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        /// <summary>
        /// Sets the active army. Used by the DocumentSelectionForm.
        /// </summary>
        /// <param name="aLa"></param>
        public static void SelectActiveArmy(ArmyListAllegiance aLa)
        {
            switch (aLa)
            {
                case ArmyListAllegiance.Attacking:
                    _currAllegiance = ArmyListAllegiance.Attacking;
                    break;
                case ArmyListAllegiance.Defending:
                    _currAllegiance = ArmyListAllegiance.Defending;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(aLa), aLa, null);
            }
        }

        private static void LoadArmy(XDocument doc)
        {
            IEnumerable<XElement> allUnits = doc.Descendants().Where(x => x.Attribute("Unit") != null);



            //foreach (XmlNode node in doc)
            //{
            //    // TODO

            //    // Find each selection node
            //    // Switch on selection type,
            //    // For units and models call load unit,
            //    // For upgrades call load wargear
            //}
        }

        /// <summary>
        /// Takes a Selection node as an input and loads the units into the correct roster
        /// </summary>
        /// <param name="unitNode">The top level unit node, directly beneith the Forces node</param>
        /// <param name="ala">The allegiance of the input Unit node</param>
        private static void LoadUnit(XmlNode unitNode, ArmyListAllegiance ala)
        {

        }

        private static void LoadModel(XmlNode node)
        {

        }

        private static void LoadWeapon(XmlNode node)
        {

        }

        private static void LoadWargear(XmlNode node)
        {

        }

        /// <summary>
        /// The different XML node selection types
        /// </summary>
        private enum SelectionType
        {
            Upgrade = 0,
            Model,
            Unit
        }

        /// <summary>
        /// The different XML node profile types.
        /// </summary>
        private enum ProfileTypeNames
        {
            WoundTrack = 0,
            Weapon,
            Unit,
            Explosion, 
            Abilities
        }
    }

    /// <summary>
    /// Which side this army list belongs to, the attacking or defending side
    /// </summary>
    public enum ArmyListAllegiance
    {
        Attacking = 0,
        Defending = 1
    }
}
