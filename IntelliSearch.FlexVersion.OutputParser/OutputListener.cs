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

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="OutputParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public interface IOutputListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="OutputParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStart([NotNull] OutputParser.StartContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OutputParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStart([NotNull] OutputParser.StartContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OutputParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] OutputParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OutputParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] OutputParser.ExprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OutputParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction([NotNull] OutputParser.FunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OutputParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction([NotNull] OutputParser.FunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OutputParser.variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariable([NotNull] OutputParser.VariableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OutputParser.variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariable([NotNull] OutputParser.VariableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OutputParser.params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParams([NotNull] OutputParser.ParamsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OutputParser.params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParams([NotNull] OutputParser.ParamsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OutputParser.text"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterText([NotNull] OutputParser.TextContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OutputParser.text"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitText([NotNull] OutputParser.TextContext context);
}
