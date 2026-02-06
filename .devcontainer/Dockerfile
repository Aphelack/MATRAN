FROM mcr.microsoft.com/dotnet/sdk:9.0

# Install Swift dependencies
RUN apt-get update && apt-get install -y \
    # Swift requirements
    clang \
    libicu-dev \
    libxml2-dev \
    libcurl4-openssl-dev \
    libpython3-dev \
    libncurses5-dev \
    libblocksruntime-dev \
    # Development tools
    git \
    curl \
    wget \
    vim \
    htop \
    tree \
    jq \
    graphviz \
    # Clean up
    && rm -rf /var/lib/apt/lists/*

# Create non-root user
ARG USERNAME=vscode
ARG USER_UID=1000
ARG USER_GID=$USER_UID
RUN groupadd --gid $USER_GID $USERNAME \
    && useradd --uid $USER_UID --gid $USER_GID -m $USERNAME \
    && echo "$USERNAME ALL=(ALL) NOPASSWD:ALL" >> /etc/sudoers

USER $USERNAME
WORKDIR /workspaces

ENV PATH="${PATH}:/home/${USERNAME}/.dotnet/tools"