﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace CompilerDemo.Model
{
    internal enum TokenType
    {
        Identifier = 0,
        Complex,
        Integer,
        Double,
        Whitespace,
        Less,
        Greater,
        OpenParenthesis,
        CloseParenthesis,
        IntegerLiteral,
        DoubleLiteral,
        Comma,
        Semicolon,

        Newline,
        Assignment,

        Plus,
        Minus,
        Multiply,
        Divide,
        Module,

        Invalid
    }

    internal class Token
    {
        public static Dictionary<string, TokenType> DefaultTypes { get; }
            = new Dictionary<string, TokenType>()
        {
            { "complex", TokenType.Complex },

            { "\n", TokenType.Newline },
            { " ", TokenType.Whitespace },
            { ",", TokenType.Comma },
            { ";", TokenType.Semicolon },
            { "=", TokenType.Assignment },

            { "(", TokenType.OpenParenthesis },
            { ")", TokenType.CloseParenthesis },

            { "+", TokenType.Plus },
            { "-", TokenType.Minus },
            { "*", TokenType.Multiply },
            { "/", TokenType.Divide },
            { "%", TokenType.Module },
        };

        public TokenType Type { get; }
        public string RawToken { get; }
        public int StartPos { get; }
        public int EndPos { get => StartPos + RawToken.Length; }

        public Token(string rawToken, int startPos)
        {
            if (rawToken.Length == 0)
                throw new ArgumentException("raw token is empty");

            RawToken = rawToken;
            StartPos = startPos;
            Type = GetTokenType(rawToken);
        }

        public static bool DefaultTokenExists(string rawToken)
            => DefaultTypes.ContainsKey(rawToken);

        private static bool IsIdentifier(string rawToken)
        {
            if (rawToken == "complex")
                return false;

            return rawToken.Length != 0 && (char.IsLetter(rawToken.First()) || rawToken.First() == '_') && Regex.IsMatch(rawToken, "^[a-zA-Z0-9_]+$");
        }
        private static bool IsIntegerLiteral(string rawToken)
            => int.TryParse(rawToken, out int _) && !rawToken.StartsWith("0.");
        private static bool IsDoubleLiteral(string rawToken)
        {
            return double.TryParse(rawToken, NumberFormatInfo.InvariantInfo, out double _)
                && (rawToken.StartsWith("0.") != !rawToken.StartsWith('0'))
                && !rawToken.EndsWith('.');
        }

        public static TokenType GetTokenType(string rawToken)
        {
            if (DefaultTokenExists(rawToken))
            {
                return DefaultTypes[rawToken];
            }
            if (IsIdentifier(rawToken))
            {
                return TokenType.Identifier;
            }
            if (IsIntegerLiteral(rawToken))
            {
                return TokenType.IntegerLiteral;
            }
            if (IsDoubleLiteral(rawToken))
            {
                return TokenType.DoubleLiteral;
            }

            return TokenType.Invalid;
        }
    }
}
