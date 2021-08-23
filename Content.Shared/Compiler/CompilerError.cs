﻿using System;

namespace Content.Shared.Compiler {
    public struct CompilerError {
        public Token Token;
        public string Message;

        public CompilerError(Token token, string message) {
            Token = token;
            Message = message;
        }

        public override string ToString() {
            string location;

            if (Token != null) {
                location = Token.SourceFile + ":" + Token.Line + ":" + Token.Column;
            } else {
                location = "(unknown location)";
            }

            return "Error at " + location + ": " + Message;
        }
    }

    public struct CompilerWarning {
        public Token Token;
        public string Message;

        public CompilerWarning(Token token, string message) {
            Token = token;
            Message = message;
        }

        public override string ToString() {
            string location;

            if (Token != null) {
                location = Token.SourceFile + ":" + Token.Line + ":" + Token.Column;
            } else {
                location = "(unknown location)";
            }

            return "Warning at " + location + ": " + Message;
        }
    }

    public class CompileErrorException : Exception {
        public CompilerError Error;

        public CompileErrorException(CompilerError error) : base(error.Message) {
            Error = error;
        }

        public CompileErrorException(string message) : base(message) {
            Error = new CompilerError(null, message);
        }
    }
}