#pragma checksum "..\..\Editor2.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "116A38F989CE42EDABBDA96C0DE81F3C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Won;


namespace Won.Editor
{


   /// <summary>
   /// xaml
   /// </summary>
   public partial class xaml : System.Windows.Window, System.Windows.Markup.IComponentConnector
   {


#line 26 "..\..\Editor2.xaml"
      [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
      internal System.Windows.Controls.Primitives.ToggleButton Bold;

#line default
#line hidden


#line 29 "..\..\Editor2.xaml"
      [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
      internal System.Windows.Controls.Primitives.ToggleButton Italic;

#line default
#line hidden


#line 32 "..\..\Editor2.xaml"
      [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
      internal System.Windows.Controls.Primitives.ToggleButton Underline;

#line default
#line hidden


#line 36 "..\..\Editor2.xaml"
      [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
      internal System.Windows.Controls.ComboBox cmbFontFamily;

#line default
#line hidden


#line 39 "..\..\Editor2.xaml"
      [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
      internal System.Windows.Controls.ComboBox cmbFontSize;

#line default
#line hidden


#line 43 "..\..\Editor2.xaml"
      [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
      internal System.Windows.Controls.RichTextBox rtbEditor;

#line default
#line hidden

      private bool _contentLoaded;

      /// <summary>
      /// InitializeComponent
      /// </summary>
      [System.Diagnostics.DebuggerNonUserCodeAttribute()]
      [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
      public void InitializeComponent()
      {
         if (_contentLoaded)
         {
            return;
         }
         _contentLoaded = true;
         System.Uri resourceLocater = new System.Uri("/Won;component/editor2.xaml", System.UriKind.Relative);

#line 1 "..\..\Editor2.xaml"
         System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
      }

      [System.Diagnostics.DebuggerNonUserCodeAttribute()]
      [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
      [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
      [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
      [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
      [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
      void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
      {
         switch (connectionId)
         {
            case 1:

#line 14 "..\..\Editor2.xaml"
               ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Open_Executed);

#line default
#line hidden
               return;
            case 2:

#line 15 "..\..\Editor2.xaml"
               ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Save_Executed);

#line default
#line hidden
               return;
            case 3:
               this.Bold = ((System.Windows.Controls.Primitives.ToggleButton)(target));
               return;
            case 4:
               this.Italic = ((System.Windows.Controls.Primitives.ToggleButton)(target));
               return;
            case 5:
               this.Underline = ((System.Windows.Controls.Primitives.ToggleButton)(target));
               return;
            case 6:
               this.cmbFontFamily = ((System.Windows.Controls.ComboBox)(target));

#line 36 "..\..\Editor2.xaml"
               this.cmbFontFamily.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbFontFamily_SelectionChanged);

#line default
#line hidden
               return;
            case 7:
               this.cmbFontSize = ((System.Windows.Controls.ComboBox)(target));

#line 39 "..\..\Editor2.xaml"
               this.cmbFontSize.AddHandler(System.Windows.Controls.Primitives.TextBoxBase.TextChangedEvent, new System.Windows.Controls.TextChangedEventHandler(this.cmbFontSize_TextChanged));

#line default
#line hidden
               return;
            case 8:
               this.rtbEditor = ((System.Windows.Controls.RichTextBox)(target));

#line 43 "..\..\Editor2.xaml"
               this.rtbEditor.SelectionChanged += new System.Windows.RoutedEventHandler(this.rtbEditor_SelectionChanged);

#line default
#line hidden
               return;
         }
         this._contentLoaded = true;
      }
   }
}

