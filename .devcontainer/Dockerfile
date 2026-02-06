FROM mcr.microsoft.com/dotnet/sdk:9.0

ARG USERNAME=vscode
ARG USER_UID=1000
ARG USER_GID=$USER_UID
ARG SWIFT_VERSION=6.2.3

# Install Swift dependencies and essential tools
RUN apt-get update && apt-get install -y \
    ca-certificates \
    clang \
    curl \
    git \
    git-lfs \
    gpg \
    jq \
    libblocksruntime-dev \
    libcurl4-openssl-dev \
    libicu-dev \
    libncurses5-dev \
    libedit-dev \
    libsqlite3-dev \
    pkg-config \
    uuid-dev \
    gcc \
    libpython3-dev \
    libxml2-dev \
    tree \
    unzip \
    vim \
    wget \
    # Clean up
    && rm -rf /var/lib/apt/lists/* \
    && git lfs install --system

# Create non-root user
RUN groupadd --gid $USER_GID $USERNAME \
    && useradd --uid $USER_UID --gid $USER_GID -m $USERNAME \
    && echo "$USERNAME ALL=(ALL) NOPASSWD:ALL" >> /etc/sudoers

USER $USERNAME
WORKDIR /workspaces

# Install Swift using swiftly for the non-root user
RUN curl -fsSL "https://download.swift.org/swiftly/linux/swiftly-$(uname -m).tar.gz" -o /tmp/swiftly.tar.gz \
    && tar -xzf /tmp/swiftly.tar.gz -C /tmp \
    && SWIFTLY_NO_INTERACTION=1 /tmp/swiftly init --quiet-shell-followup --skip-install --no-modify-profile \
    && SWIFTLY_NO_INTERACTION=1 /home/${USERNAME}/.local/share/swiftly/bin/swiftly install ${SWIFT_VERSION} \
    && rm -rf /tmp/swiftly /tmp/swiftly.tar.gz

ENV SWIFTLY_HOME_DIR="/home/${USERNAME}/.local/share/swiftly"
ENV PATH="/home/${USERNAME}/.local/share/swiftly/bin:${PATH}:/home/${USERNAME}/.dotnet/tools"