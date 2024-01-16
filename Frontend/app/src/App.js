import React, { useState } from "react";
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import "./pages/authentication/Authentication.css";
import { Login } from "./pages/authentication/Login";
import { RecoverPassword } from "./pages/authentication/RecoverPassword";
import { Register } from "./pages/authentication/Register";
import Home from "./pages/home/Home";
import Chat from "./pages/chat/Chat";

function App() {
  const [currentForm, setCurrentForm] = useState("login");

  const toggleForm = (forName) => {
    setCurrentForm(forName);
  };
  return (
    <>
      <Router>
        <Routes>
          <Route exact path="/Authentication/Login" element={<Login />} />
          <Route
            exact
            path="/Authentication/RecoverPassword"
            element={<RecoverPassword />}
          />
          <Route exact path="/Authentication/Register" element={<Register />} />
          <Route exact path="" element={<Login />} />
          <Route exact path="/Home" element={<Home />} />
          <Route exact path="/Chat" element={<Chat />} />
          {/* <Route exact path="/Profile" element={<Profile />} />
          <Route exact path="/AdminPage" element={<AdminPage/>}/>
          <Route exact path="/Feed" element={<Feed />} />
          <Route exact path="/Home" element={<Home />} /> */}
        </Routes>
      </Router>
    </>
  );
}

export default App;
