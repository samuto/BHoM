﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BHoM.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BHoM.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;__Type__&quot;:&quot;BHoMTest.Database&quot;,&quot;Name&quot;: &quot;Materials&quot;,&quot;Tables&quot;: [{&quot;__Type__&quot;:&quot;BHoMTest.Table&quot;,&quot;Name&quot;: &quot;Europe&quot;,&quot;Rows&quot;: [{&quot;__Type__&quot;:&quot;BHoM.Structural.Databases.MaterialRow&quot;,&quot;Name&quot;: &quot;S235&quot;,&quot;Type&quot;: &quot;Steel&quot;,&quot;Id&quot;: 1,&quot;Grade&quot;: &quot;S235&quot;,&quot;IsDefault&quot;: &quot;false&quot;,&quot;Weight&quot;: 76972.86394,&quot;Mass&quot;: 7850,&quot;YoungsModulus&quot;: 210000000000,&quot;PoissonsRatio&quot;: 0.3,&quot;CoefOfThermalExpansion&quot;: 1.17E-05,&quot;MinimumYieldStress&quot;: 235000000,&quot;MinimumTensileStress&quot;: 360000000,&quot;EffectiveYieldStress&quot;: 258500000,&quot;EffectiveTensileStress&quot;: 396000000,&quot;Compress [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MaterialDB {
            get {
                return ResourceManager.GetString("MaterialDB", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;__Type__&quot;:&quot;BHoMTest.Database&quot;,&quot;Name&quot;: &quot;SteelSections&quot;,&quot;Tables&quot;: [{&quot;__Type__&quot;:&quot;BHoMTest.Table&quot;,&quot;Name&quot;: &quot;UK_Sections&quot;,&quot;Rows&quot;: [{&quot;__Type__&quot;:&quot;BHoM.Structural.Databases.SteelSectionRow&quot;,&quot;Name&quot;: &quot;2L 60x5x0&quot;,&quot;Type&quot;: &quot;CEAB&quot;,&quot;Id&quot;: 1512,&quot;Shape&quot;: 22,&quot;Mass&quot;: 9.14,&quot;Height&quot;: 0.06,&quot;Width&quot;: 0.12,&quot;B1&quot;: 0,&quot;B2&quot;: 0,&quot;B3&quot;: 0,&quot;T1&quot;: 0.005,&quot;T2&quot;: 0.005,&quot;T3&quot;: 0,&quot;r1&quot;: 0.008,&quot;r2&quot;: 0.0024,&quot;GAP&quot;: 0,&quot;Angle&quot;: 0,&quot;CxPlus&quot;: 0,&quot;CxMinus&quot;: 0,&quot;CyPlus&quot;: 0,&quot;CyMinus&quot;: 0,&quot;Name1&quot;: &quot;2L 60x5x0&quot;,&quot;Name2&quot;: &quot;2L 60x5x0&quot;},{&quot;__Type__&quot;:&quot;BHoM.Structural.Databa [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SteelSectionDB {
            get {
                return ResourceManager.GetString("SteelSectionDB", resourceCulture);
            }
        }
    }
}
