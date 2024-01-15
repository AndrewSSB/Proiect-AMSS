import React, { useEffect } from "react";
import {ReactComponent as Reading} from './reading.svg';
import { useState } from "react";
import { _get } from "../../utils/api";
import {getToken, deleteToken} from "../../utils/storage";
import Boook from "./book";
import "./index.css";
import { jwtDecode } from "jwt-decode";

import { useNavigate } from "react-router-dom";

const Home = () => {
    const history = useNavigate();
    const [token, setToken] = useState(() => {
      return jwtDecode(getToken("token"))
    });
    const handleLogOut = () => {
      deleteToken();
      history("/");
    }
    return (
        <div>
            <p> home page</p>
            <div >
              <button id="logout-button" onClick={handleLogOut}>Logout</button>
            </div>
        </div>
    )
    
};

export default Home;