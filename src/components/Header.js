import React from 'react';
import "./Header.css";

const Header = () => {
    return (
        <header>
            <a href="#" className="logo"><span>H</span>ospital  <span>I</span>nformation <span>M</span>anagement <span>S</span>ystem</a>
            <nav className="navbar">
                <ul>
                    <li><a href="#home">Home</a></li>
                    <li><a href="#about">About</a></li>
                    <li><a href="#doctor">Doctor</a></li>
                    <li><a href="#nurse">Nurse</a></li>
                    <li><a href="#review">Review</a></li>
                    <li><a href="#contact">Contact</a></li>
                    <li><a href="#blog">Blog</a></li>
                </ul>
            </nav>
            <div className="fas fa-bars"></div>
        </header>
    );
};

export default Header;