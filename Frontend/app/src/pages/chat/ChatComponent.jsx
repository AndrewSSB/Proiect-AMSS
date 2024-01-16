import React, { useState, useEffect } from "react";

const ChatComponent = ({ username }) => {
  const [messages, setMessages] = useState([]);
  const [newMessage, setNewMessage] = useState("");

  const simulateReceiveMessage = () => {
    setTimeout(() => {
      const receivedMessage = {
        sender: "Other User",
        text: "Hello, how are you?",
      };
      setMessages((prevMessages) => [...prevMessages, receivedMessage]);
    }, 1000);
  };

  useEffect(() => {
    simulateReceiveMessage();
  }, []);

  const handleSendMessage = () => {
    const newMessageObj = {
      sender: "You",
      text: newMessage,
    };

    if (newMessage !== "") {
      setMessages((prevMessages) => [...prevMessages, newMessageObj]);
      setNewMessage("");
    }
  };

  return (
    <div
      className="chat-box"
      style={{
        display: "flex",
        flexDirection: "column",
        height: "100%",
      }}
    >
      <div className="chat-header" style={{ backgroundColor: "#D9D9D9" }}>
        <h2>Chatting with {username}</h2>
      </div>
      <div
        className="chat-messages"
        style={{
          marginTop: "10px",
          flexGrow: 1,
          overflowY: "auto",
          backgroundColor: "#F3F3F3",
        }}
      >
        {messages.map((message, index) => (
          <div
            key={index}
            className={message.sender === "You" ? "sent" : "received"}
          >
            <div style={{ display: "flex", flexDirection: "column" }}>
              <span>
                <strong>{message.sender} </strong>
              </span>
              <span style={{ margin: "5px 0px 5px 0px" }}>{message.text}</span>
            </div>
          </div>
        ))}
      </div>
      <div
        className="chat-input"
        style={{
          position: "relative",
          marginTop: "20px",
          marginBottom: "-30px",
          display: "flex",
          flexDirection: "row",
        }}
      >
        <input
          style={{
            width: "100%",
            borderRadius: "20px",
            padding: "10px",
            marginRight: "20px",
            border: "1px solid grey",
          }}
          type="text"
          placeholder="Type your message..."
          value={newMessage}
          onChange={(e) => setNewMessage(e.target.value)}
        />
        <button
          style={{
            width: "100px",
            height: "40px",
            display: "flex",
            alignItems: "center",
            justifyContent: "center",
            borderRadius: "20px",
            border: "3px solid grey",
          }}
          onClick={handleSendMessage}
        >
          Send
        </button>
      </div>
    </div>
  );
};

export default ChatComponent;
