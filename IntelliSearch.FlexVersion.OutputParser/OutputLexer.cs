//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Output.g4 by ANTLR 4.7.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public partial class OutputLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		FUNC=1, VAR=2, OPEN_PAR=3, CLOSE_PAR=4, COMMA=5, OTHER=6;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"FUNC", "VAR", "OPEN_PAR", "CLOSE_PAR", "COMMA", "OTHER", "ID"
	};


	public OutputLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public OutputLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, "'('", "')'", "','"
	};
	private static readonly string[] _SymbolicNames = {
		null, "FUNC", "VAR", "OPEN_PAR", "CLOSE_PAR", "COMMA", "OTHER"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Output.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static OutputLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\b', '\'', '\b', '\x1', '\x4', '\x2', '\t', '\x2', '\x4', 
		'\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', 
		'\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', 
		'\b', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', 
		'\b', '\x3', '\b', '\a', '\b', '#', '\n', '\b', '\f', '\b', '\xE', '\b', 
		'&', '\v', '\b', '\x2', '\x2', '\t', '\x3', '\x3', '\x5', '\x4', '\a', 
		'\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\x2', '\x3', '\x2', 
		'\x4', '\x5', '\x2', '\x43', '\\', '\x61', '\x61', '\x63', '|', '\x6', 
		'\x2', '\x32', '<', '\x43', '\\', '\x61', '\x61', '\x63', '|', '\x2', 
		'&', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', 
		'\x3', '\x2', '\x2', '\x2', '\x3', '\x11', '\x3', '\x2', '\x2', '\x2', 
		'\x5', '\x14', '\x3', '\x2', '\x2', '\x2', '\a', '\x18', '\x3', '\x2', 
		'\x2', '\x2', '\t', '\x1A', '\x3', '\x2', '\x2', '\x2', '\v', '\x1C', 
		'\x3', '\x2', '\x2', '\x2', '\r', '\x1E', '\x3', '\x2', '\x2', '\x2', 
		'\xF', ' ', '\x3', '\x2', '\x2', '\x2', '\x11', '\x12', '\a', '&', '\x2', 
		'\x2', '\x12', '\x13', '\x5', '\xF', '\b', '\x2', '\x13', '\x4', '\x3', 
		'\x2', '\x2', '\x2', '\x14', '\x15', '\a', '>', '\x2', '\x2', '\x15', 
		'\x16', '\x5', '\xF', '\b', '\x2', '\x16', '\x17', '\a', '@', '\x2', '\x2', 
		'\x17', '\x6', '\x3', '\x2', '\x2', '\x2', '\x18', '\x19', '\a', '*', 
		'\x2', '\x2', '\x19', '\b', '\x3', '\x2', '\x2', '\x2', '\x1A', '\x1B', 
		'\a', '+', '\x2', '\x2', '\x1B', '\n', '\x3', '\x2', '\x2', '\x2', '\x1C', 
		'\x1D', '\a', '.', '\x2', '\x2', '\x1D', '\f', '\x3', '\x2', '\x2', '\x2', 
		'\x1E', '\x1F', '\v', '\x2', '\x2', '\x2', '\x1F', '\xE', '\x3', '\x2', 
		'\x2', '\x2', ' ', '$', '\t', '\x2', '\x2', '\x2', '!', '#', '\t', '\x3', 
		'\x2', '\x2', '\"', '!', '\x3', '\x2', '\x2', '\x2', '#', '&', '\x3', 
		'\x2', '\x2', '\x2', '$', '\"', '\x3', '\x2', '\x2', '\x2', '$', '%', 
		'\x3', '\x2', '\x2', '\x2', '%', '\x10', '\x3', '\x2', '\x2', '\x2', '&', 
		'$', '\x3', '\x2', '\x2', '\x2', '\x4', '\x2', '$', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
