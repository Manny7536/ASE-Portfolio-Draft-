# AI System Selection

## Chosen AI System

For this project, Google Gemini 1.5 Pro was selected as the primary AI assistant to support the development process.

### Why I Chose Gemini

I selected Google Gemini 1.5 Pro because it provides strong capabilities in software development, research, code generation, debugging, and technical explanations. Since this project combines programming with domain-specific knowledge related to astronomy, Gemini was useful for understanding astronomical concepts and assisting with Python development.

Its large context window also made it suitable for handling longer conversations, maintaining project context, and working with multiple code sections. It was particularly helpful in:

Generating and improving Python functions.

Explaining astronomical concepts and phenomena.

Assisting with code generation and debugging.

Providing technical explanations and documentation.

Troubleshooting development issues.

## How AI Was Used

Gemini was used as a development assistant throughout the project rather than as a replacement for independent thinking or problem-solving.

All AI-generated code and information were reviewed, tested, and modified where necessary before being incorporated into the project. This ensured that the final implementation met the project requirements and that the developer maintained an aof the code and its functionality.

## Environment Setup and Configuration

### Development Environment

The project development environment was configured using **Visual Studio 2026**, **LM Studio**, and **LiteLLM** to support both local and cloud-based AI model integration.

The following tools and technologies were used:

- **Visual Studio 2026:** Main development environment for writing and managing the project code.
- **LM Studio:** Used to download, load, and run a local Large Language Model (LLM).
- **LiteLLM:** Used as an API proxy to connect and manage different AI models through a unified endpoint.
- **Google Gemini API:** Configured as an additional cloud-based AI model.

### Local LLM Setup Using LM Studio

<p>A local AI model was configured using <strong>LM Studio</strong>, allowing the project to run an LLM directly on the local machine without requiring an external API connection.</p>

**Model Used:** `Llama-3.2-3B-Instruct-Q8_0-GGUF`

**Model Identifier:** `llama-3.2-3b-instruct`

The following steps were followed:

1. Downloaded and installed LM Studio.
2. Downloaded the `Llama-3.2-3B-Instruct-Q8_0-GGUF` model.
3. Loaded the model into LM Studio.
4. Started the local API server using the OpenAI-compatible API.
5. Configured the local server endpoint.

**Local API Endpoint:**

```text
http://127.0.0.1:1234/v1
```

### LiteLLM Configuration

<p><strong>LiteLLM</strong> was installed and configured to act as a proxy between the development environment and the AI models. This allowed different models to be accessed through a single API endpoint.</p>

**Installation commands:**

```bash
pip install litellm
pip install "litellm[proxy]"
```

A `config.yaml` file was created in the repository root directory to define the AI model configurations.

The LiteLLM proxy was configured to run on port `4000`.

**LiteLLM API Endpoint:**

```text
http://127.0.0.1:4000/v1
```

### Google Gemini API Configuration

<p>Google Gemini was also configured as a cloud-based AI model through LiteLLM. The <strong>Gemini 2.5 Flash</strong> model was selected for this integration.</p>

The Gemini API key was intended to be stored securely in a `.env` file rather than directly in the source code.

**Environment variable:**

```env
GEMINI_API_KEY=your_gemini_api_key
LITELLM_MASTER_KEY=your_litellm_master_key
```

**Note:** Gemini integration was attempted, but API requests encountered a <strong>403 access error</strong> due to unavailable free-tier access. Therefore, the local LM Studio model was used for local AI integration.

### Running the AI Environment

The following steps are required to start the configured environment:

1. Open LM Studio and load the downloaded Llama model.
2. Start the local API server on port `1234`.
3. Open the project repository in Visual Studio.
4. Open the terminal in the repository root directory.
5. Start the LiteLLM proxy using:

```bash
litellm --config config.yaml --port 4000
```

6. Configure the development environment to communicate with the LiteLLM endpoint:

```text
http://127.0.0.1:4000/v1
```

7. The local AI model can then be accessed through the configured proxy.

### Configuration and Security

- The `config.yaml` file contains the AI model and proxy configuration.
- The `.env` file stores API keys and secret credentials.
- Sensitive credentials should never be committed to the public GitHub repository.
- The `.env` file should be included in `.gitignore`.
