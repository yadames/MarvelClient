﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarvelClient.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MarvelClient.Resources.Resource", typeof(Resource).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marvel Client.
        /// </summary>
        public static string APP_NAME {
            get {
                return ResourceManager.GetString("APP_NAME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The hero id must contain only numbers..
        /// </summary>
        public static string HERO_ID_INVALID {
            get {
                return ResourceManager.GetString("HERO_ID_INVALID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to # Comics.
        /// </summary>
        public static string LABEL_COMICS_COUNT {
            get {
                return ResourceManager.GetString("LABEL_COMICS_COUNT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Description.
        /// </summary>
        public static string LABEL_DESCRIPTION {
            get {
                return ResourceManager.GetString("LABEL_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hero ID.
        /// </summary>
        public static string LABEL_HERO_ID {
            get {
                return ResourceManager.GetString("LABEL_HERO_ID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Home.
        /// </summary>
        public static string LABEL_HOME_PAGE {
            get {
                return ResourceManager.GetString("LABEL_HOME_PAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name.
        /// </summary>
        public static string LABEL_NAME {
            get {
                return ResourceManager.GetString("LABEL_NAME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Find information about your favorite hero.
        /// </summary>
        public static string LABEL_WELCOME {
            get {
                return ResourceManager.GetString("LABEL_WELCOME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Send Query.
        /// </summary>
        public static string SEND_QUERY {
            get {
                return ResourceManager.GetString("SEND_QUERY", resourceCulture);
            }
        }
    }
}
