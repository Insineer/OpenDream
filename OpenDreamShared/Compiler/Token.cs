﻿namespace OpenDreamShared.Compiler {
    // Must be : byte for ReadOnlySpan<TokenType> x = new TokenType[] { } to be intrinsic'd by the compiler.
    public enum TokenType : byte {
        //Base lexer
        Error,
        Warning,
        Unknown,
        Skip, //Internally skipped by the lexer

        //Text lexer
        Newline,
        EndOfFile,

        //DM Preprocessor
        DM_Preproc_ConstantString,
        DM_Preproc_Define,
        DM_Preproc_Else,
        DM_Preproc_EndIf,
        DM_Preproc_Error,
        DM_Preproc_Identifier,
        DM_Preproc_If,
        DM_Preproc_Ifdef,
        DM_Preproc_Ifndef,
        DM_Preproc_Include,
        DM_Preproc_Number,
        DM_Preproc_ParameterStringify,
        DM_Preproc_Punctuator,
        DM_Preproc_Punctuator_Colon,
        DM_Preproc_Punctuator_Comma,
        DM_Preproc_Punctuator_LeftBracket,
        DM_Preproc_Punctuator_LeftParenthesis,
        DM_Preproc_Punctuator_Period,
        DM_Preproc_Punctuator_Question,
        DM_Preproc_Punctuator_RightBracket,
        DM_Preproc_Punctuator_RightParenthesis,
        DM_Preproc_String,
        DM_Preproc_TokenConcat,
        DM_Preproc_Undefine,
        DM_Preproc_Warning,
        DM_Preproc_Whitespace,

        //DM
        DM_And,
        DM_AndAnd,
        DM_AndEquals,
        DM_AndAndEquals,
        DM_As,
        DM_Bar,
        DM_BarBar,
        DM_BarEquals,
        DM_BarBarEquals,
        DM_Break,
        DM_Call,
        DM_Catch,
        DM_Colon,
        DM_Comma,
        DM_Continue,
        DM_Dedent,
        DM_Del,
        DM_Do,
        DM_Else,
        DM_Equals,
        DM_EqualsEquals,
        DM_Exclamation,
        DM_ExclamationEquals,
        DM_Float,
        DM_For,
        DM_Goto,
        DM_GreaterThan,
        DM_GreaterThanEquals,
        DM_Identifier,
        DM_If,
        DM_In,
        DM_Indent,
        DM_IndeterminateArgs,
        DM_RightShift,
        DM_RightShiftEquals,
        DM_Integer,
        DM_LeftBracket,
        DM_LeftCurlyBracket,
        DM_LeftParenthesis,
        DM_LeftShift,
        DM_LeftShiftEquals,
        DM_LessThan,
        DM_LessThanEquals,
        DM_Minus,
        DM_MinusEquals,
        DM_MinusMinus,
        DM_Modulus,
        DM_ModulusEquals,
        DM_New,
        DM_Null,
        DM_Period,
        DM_Plus,
        DM_PlusEquals,
        DM_PlusPlus,
        DM_Proc,
        DM_Question,
        DM_QuestionColon,
        DM_QuestionPeriod,
        DM_RawString,
        DM_Resource,
        DM_Return,
        DM_RightBracket,
        DM_RightCurlyBracket,
        DM_RightParenthesis,
        DM_Semicolon,
        DM_Set,
        DM_Slash,
        DM_SlashEquals,
        DM_Spawn,
        DM_Star,
        DM_StarEquals,
        DM_StarStar,
        DM_Step,
        DM_String,
        DM_SuperProc,
        DM_Switch,
        DM_Throw,
        DM_Tilde,
        DM_TildeEquals,
        DM_TildeExclamation,
        DM_To,
        DM_Try,
        DM_Var,
        DM_While,
        DM_Whitespace,
        DM_Xor,
        DM_XorEquals,

        //DMF
        DMF_Attribute,
        DMF_Boolean,
        DMF_Bottom,
        DMF_BottomLeft,
        DMF_BottomRight,
        DMF_Browser,
        DMF_Button,
        DMF_Center,
        DMF_Child,
        DMF_Color,
        DMF_Dimension,
        DMF_Distort,
        DMF_Elem,
        DMF_Equals,
        DMF_Info,
        DMF_Input,
        DMF_Integer,
        DMF_Label,
        DMF_Left,
        DMF_Macro,
        DMF_Main,
        DMF_Map,
        DMF_Menu,
        DMF_None,
        DMF_Output,
        DMF_Position,
        DMF_PushBox,
        DMF_PushButton,
        DMF_Resource,
        DMF_Right,
        DMF_Stretch,
        DMF_String,
        DMF_Sunken,
        DMF_Top,
        DMF_TopLeft,
        DMF_TopRight,
        DMF_Vertical,
        DMF_Window
    }

    public partial class Token {
        public TokenType Type;
        public string Text;
        public string SourceFile;
        public int Line, Column;
        public object Value;

        public string PrintableText {
            get => Text?.Replace("\n", "\\n").Replace("\r", "\\r").Replace("\t", "\\t");
        }

        public Token(TokenType type, string text, string sourceFile, int line, int column, object value) {
            Type = type;
            Text = text;
            SourceFile = sourceFile;
            Line = line;
            Column = column;
            Value = value;
        }

        public override string ToString() {
            return Type + "(" + SourceFile + ":" + Line + ":" + Column + ", " + PrintableText + ")";
        }
    }
}
