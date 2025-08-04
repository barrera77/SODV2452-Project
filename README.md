# SODV2452-Project
# Awesome Chat

Awesome Chat is a simple Windows Forms chat client for LAN environments.

## Features

- Login with "Remember Me"
- Send and receive messages via TCP server
- Timestamped message history
- SQLite-based persistence

## Installation

1. Run `AwesomeChatSetup.exe`
2. Follow the installation wizard
3. Launch the app from the desktop or start menu

## Requirements

- .NET 8.0 Desktop Runtime
- Windows 10/11

## How It Works

- Messages are sent to a TCP server at `127.0.0.1:1234`
- Server echoes back the message
- SQLite is used to store previously used usernames

## License

For educational purposes at Bow Valley College.
