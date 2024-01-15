import React, { useEffect } from "react";
import Navbar from "../navbar/navbar";
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


    if (token && (token?.role === "User" || token?.role === "Admin")) {
        return(
            <>
            <Navbar></Navbar>
            <body>
                <header className="header-container">
                    <h1> Book Hub</h1>
                    <p>Connecting book lovers through the joy of sharing and swapping stories.</p>
                </header>

                <div className="body-container">
                    <h2>Welcome to Your Book Exchange!</h2>
                    <p>Discover a community of avid readers who love to share their favorite books. Whether you're looking to
                        explore new genres or share your well-loved classics, our book exchange platform brings readers together.
                        Join us and embark on a literary journey like never before.</p>

                    <h2>How it Works</h2>
                    <p>
                        1. Browse available books for exchange<br></br>
                        2. Request a swap with other user<br></br>
                        3. Connect with fellow book enthusiasts<br></br>
                        4. Share your thoughts and experiences
                    </p>

                    <h2>Start Exchanging Today!</h2>
                    <p>Join our growing community of book lovers and experience the joy of sharing stories.</p>
                </div>
            </body>
            </>
           
        )
    } else {
        history("/Authentication/Login");
    }
    
};

export default Home;