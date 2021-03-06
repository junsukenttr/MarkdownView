﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.544
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarkdownView.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
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
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
					global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MarkdownView.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   厳密に型指定されたこのリソース クラスを使用して、すべての検索リソースに対し、
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
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
        ///   &lt;body&gt;
        ///	&lt;div class=&quot;hatena-body&quot;&gt;
        ///		&lt;div class=&quot;main&quot;&gt;
        ///			&lt;div id=&quot;days&quot;&gt;
        ///				&lt;div class=&quot;day&quot;&gt;
        ///					&lt;div class=&quot;body&quot;&gt;
        ///						&lt;!-- {$body} --&gt;
        ///					&lt;/div&gt;
        ///				&lt;/div&gt;
        ///			&lt;/div&gt;
        ///		&lt;/div&gt;
        ///	&lt;/div&gt;
        ///&lt;/body&gt;
        /// に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string body {
            get {
                return ResourceManager.GetString("body", resourceCulture);
            }
        }
        
        /// <summary>
        ///   &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///  &lt;head&gt;
        ///    &lt;title&gt;&lt;/title&gt;
        ///    &lt;meta http-equiv=&quot;Content-Type&quot; content=&quot;text/html; charset=utf-8&quot; /&gt;
        ///    &lt;link rel=&quot;stylesheet&quot; href=&quot;&lt;!-- {$css} --&gt;&quot; type=&quot;text/css&quot; media=&quot;all&quot; /&gt;
        ///  &lt;/head&gt;
        ///	&lt;body&gt;
        ///	&lt;/body&gt;
        ///&lt;/html&gt;
        /// に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string html {
            get {
                return ResourceManager.GetString("html", resourceCulture);
            }
        }
    }
}
