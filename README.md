# 🤖 .NET AI Agent Playground

A hands-on learning project for building AI agents with **.NET** and **Semantic Kernel** — focused on **Tool Calling / Function Calling**, where the language model decides on its own when and which function to invoke in order to answer a user's question.
 
## ✨ Features

- Connects to language models via [Groq](https://groq.com) (free and fast, OpenAI-compatible API)
- Defines custom tools with `[KernelFunction]` that the model can invoke automatically
- Practical example: a book/game store assistant that checks stock and calculates discounted prices

## 🛠 Tech Stack

| Tool                        | Role                                                       |
| --------------------------- | ---------------------------------------------------------- |
| .NET 10                     | Core language and runtime                                  |
| Microsoft.SemanticKernel    | Framework for building the agent and handling tool calling |
| Groq API (OPENAI / GPT-OSS) | Underlying language model                                  |

## 🚀 Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- A free API key from [console.groq.com/keys](https://console.groq.com/keys)

### Steps

1. Clone the repo:

   ```bash
   git clone https://github.com/rralireza/dotnet-ai-agent-playground.git
   cd dotnet-ai-agent-playground
   ```

2. Set your API key as an environment variable:

   **Windows (PowerShell):**

   ```powershell
   setx GROQ_API_KEY "gsk_..."
   ```

   **Linux / macOS:**

   ```bash
   export GROQ_API_KEY="gsk_..."
   ```

   > After running `setx`, close and reopen your terminal/IDE for the variable to take effect.

3. Run it:
   ```bash
   dotnet run
   ```

## 📂 Project Structure

```
├── Program.cs           # Entry point: Kernel setup and prompt execution
├── BookStoreTools.cs    # Store tools (stock check, discounted pricing)
└── MyFirstAgent.csproj
```

## 🧠 Concepts Covered

- **ReAct Loop** — the Reason → Act → Observe cycle that underlies every agent
- **Function/Tool Calling** — exposing a C# method to the model so it can decide when to call it
- Using OpenAI-compatible endpoints (like Groq) without changing the code's architecture

## 🗺 Next Steps

- [ ] Add a tool to search by author/genre
- [ ] Connect to a real database instead of in-memory fake data
- [ ] Wrap the agent in a Minimal API with ASP.NET Core

## 📄 License

This project is licensed under the [MIT License](LICENSE).
