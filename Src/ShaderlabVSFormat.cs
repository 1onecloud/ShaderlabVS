﻿using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace ShaderlabVS
{
    #region Format definition
    /// <summary>
    /// Text
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.ShaderlabText)]
    [Name(Constants.ShaderlabText)]
    [UserVisible(true)] //this should be visible to the end user
    [Order(Before = Priority.Default)] //set the priority to be after the default classifiers
    internal sealed class ShaderlabTextFormat : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "Shaderlab-Text" classification type
        /// </summary>
        public ShaderlabTextFormat()
        {
            this.DisplayName = Constants.ShaderlabText;
        }
    }

    /// <summary>
    /// Strings
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.ShaderlabStrings)]
    [Name(Constants.ShaderlabStrings)]
    [UserVisible(true)] //this should be visible to the end user
    [Order(Before = Priority.Default)] //set the priority to be after the default classifiers
    internal sealed class ShaderlabStrings : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "Shaderlab-Text" classification type
        /// </summary>
        public ShaderlabStrings()
        {
            this.DisplayName = Constants.ShaderlabStrings;
            this.ForegroundColor = Colors.DarkRed;
        }
    }

    /// <summary>
    /// Shader lab functions
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.ShaderlabFunction)]
    [Name(Constants.ShaderlabFunction)]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class ShaderlabFunctionFormat : ClassificationFormatDefinition
    {
        public ShaderlabFunctionFormat()
        {
            this.DisplayName = Constants.ShaderlabFunction;
            this.ForegroundColor = Colors.DarkMagenta;
        }
    }

    /// <summary>
    /// Comments
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.ShaderlabComment)]
    [Name(Constants.ShaderlabComment)]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class ShaderlabComment : ClassificationFormatDefinition
    {
        public ShaderlabComment()
        {
            this.DisplayName = Constants.ShaderlabComment;
            this.ForegroundColor = Colors.ForestGreen;
        }
    }

    /// <summary>
    /// keywords
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.ShaderlabKeyword)]
    [Name(Constants.ShaderlabKeyword)]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class ShaderlabKeyword : ClassificationFormatDefinition
    {
        public ShaderlabKeyword()
        {
            this.DisplayName = Constants.ShaderlabKeyword;
            this.ForegroundColor = Colors.Blue;
        }
    }

    /// <summary>
    /// Unity3D keywords
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.ShaderlabUnityBlockKeywords)]
    [Name(Constants.ShaderlabUnityBlockKeywords)]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class ShaderlabUnityBlockKeywords : ClassificationFormatDefinition
    {
        public ShaderlabUnityBlockKeywords()
        {
            this.DisplayName = Constants.ShaderlabUnityBlockKeywords;
            this.ForegroundColor = Colors.Blue;
        }
    }

    /// <summary>
    /// Unity3D keywords
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.ShaderlabUnityNonBlockKeywords)]
    [Name(Constants.ShaderlabUnityNonBlockKeywords)]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class ShaderlabUnityNonBlockKeywords : ClassificationFormatDefinition
    {
        public ShaderlabUnityNonBlockKeywords()
        {
            this.DisplayName = Constants.ShaderlabUnityNonBlockKeywords;
            this.ForegroundColor = Colors.DarkMagenta;
        }
    }

    /// <summary>
    /// Data type
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.ShaderlabDataType)]
    [Name(Constants.ShaderlabDataType)]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class ShaderlabDataType : ClassificationFormatDefinition
    {
        public ShaderlabDataType()
        {
            this.DisplayName = Constants.ShaderlabDataType;
            this.ForegroundColor = Colors.Blue;
        }
    }

    #endregion //Format definition
}
