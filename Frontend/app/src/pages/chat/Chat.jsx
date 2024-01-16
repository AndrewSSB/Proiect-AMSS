import { useState } from "react";
import Navbar from "../navbar/navbar";
import "../chat/Chat.css";
import ChatComponent from "./ChatComponent";

export default function Chat() {
  const [selectedUser, setSelectedUser] = useState(null);
  const users = ["User1", "User2", "User3"];

  const handleUserClick = (username) => {
    setSelectedUser(username);
  };

  return (
    <>
      <Navbar />
      <div className="chat-container">
        <div className="user-list">
          <h2>Readers</h2>
          <ul>
            {users.map((user) => (
              <li key={user} onClick={() => handleUserClick(user)}>
                {user}
              </li>
            ))}
          </ul>
        </div>

        <div className="chat-component">
          {selectedUser ? (
            <ChatComponent username={selectedUser} />
          ) : (
            <div className="chat-header">
              <p>Select a user to start chatting</p>
            </div>
          )}
        </div>
      </div>
    </>
  );
}
