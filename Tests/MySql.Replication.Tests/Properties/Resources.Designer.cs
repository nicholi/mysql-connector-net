﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySql.Replication.Tests.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MySql.Replication.Tests.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to -- Users
        ///
        ///GRANT ALL ON *.* TO lbuser@localhost IDENTIFIED BY &apos;lbpass&apos;;
        ///
        ///REVOKE SUPER ON *.* FROM lbuser@localhost;
        ///.
        /// </summary>
        internal static string _01_Startup_root_script {
            get {
                return ResourceManager.GetString("_01_Startup_root_script", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DROP DATABASE IF EXISTS {0};
        ///
        ///
        ///CREATE DATABASE {0};
        ///USE {0};
        ///
        ///CREATE TABLE items (
        ///  item_id int primary key auto_increment,
        ///  description varchar(50) not null,
        ///  brand varchar(50),
        ///  price float not null,
        ///  quantity int not null
        ///);
        ///
        ///CREATE TABLE stores(
        ///  store_id int primary key auto_increment,
        ///  name varchar(50) not null,
        ///  address varchar(100)
        ///);
        ///
        ///CREATE TABLE employees(
        ///  employee_id int primary key auto_increment,
        ///  name varchar(50) not null,
        ///  store_id int,
        ///  active bool
        ///);
        ///
        ///CREATE TABLE orders(
        ///  or [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _02_Startup_script {
            get {
                return ResourceManager.GetString("_02_Startup_script", resourceCulture);
            }
        }
    }
}
