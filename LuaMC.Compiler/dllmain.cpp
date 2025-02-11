#include <iostream>
#include <sstream>
#include <fstream>
#include <string>

typedef void(__stdcall* LogCallback)(const char* msg);
LogCallback g_LogCallback = nullptr;

void Log(std::string data) {
	if (g_LogCallback != nullptr)
		g_LogCallback(("[LuaMC.Compiler]" + data).c_str());
}

#include "Envrionment/Envrionment.h"
#include "Compiler/LuaTokenizer.h"
#include "Compiler/MCDatapack.h"

extern "C" __declspec(dllexport) void __stdcall SetLogCallback(LogCallback callback) {
	g_LogCallback = callback;
}

// unused junk
extern "C" __declspec(dllexport) Token* Tokenize(const char* src, int* outTokenCount) {
	LuaTokenizer tokenizer(src);

	std::vector<Token> tokens = tokenizer.tokenize();

	*outTokenCount = tokens.size();

	Token* result = new Token[tokens.size()];
	for (size_t i = 0; i < tokens.size(); ++i)
		result[i] = tokens[i];

	return result;
}

extern "C" __declspec(dllexport) void Build(const char* src, const char* outputDir) {
	// read script contents
	std::string content(src);

	// create datapack project instance using script contents
	MCDatapack pack = MCDatapack::Create(content);

	try {
		// attempt to compile datapack
		auto datapack = pack.Compile();
		//for (auto func : datapack) { std::cout << "\nFunc Name: " << func.FuncName << " Content:\n" << func.Content << "\n"; }
		Log(std::string("Build successfull"));
	}
	catch (std::exception ex) {
		Log(std::string("Error while compiling lua2datapack ") + ex.what());
	}

	Log("TODO: build result at " + std::string(outputDir));
}
