import React from 'react';
import './Footer.css';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faFacebookF, faTwitter, faInstagram, faPinterest } from '@fortawesome/free-brands-svg-icons';

const Footer = () => {
    return (
        <footer className="footer">
            <div className="footer-container">
                <div className="footer-box">
                    <h2 className="logo"><span>H</span>ospital <span>I</span>nformation <span>M</span>anagement <span>S</span>ystem</h2>
                    <p className="tagline">Safe, Reliable & Health-Conscious</p>
                </div>
                <div className="footer-box">
                    <h2 className="section-title">Follow Us</h2>
                    <div className="social-links">
                        <a href="#" className="social-icon"><FontAwesomeIcon icon={faFacebookF} /></a>
                        <a href="#" className="social-icon"><FontAwesomeIcon icon={faTwitter} /></a>
                        <a href="#" className="social-icon"><FontAwesomeIcon icon={faInstagram} /></a>
                        <a href="#" className="social-icon"><FontAwesomeIcon icon={faPinterest} /></a>
                    </div>
                </div>
                <div className="footer-box">
                    <h2 className="section-title">Quick Links</h2>
                    <nav className="links">
                        <a href="#">Home</a>
                        <a href="#">About</a>
                        <a href="#">Doctors</a>
                        <a href="#">Reviews</a>
                        <a href="#">Contact</a>
                        <a href="#">Blog</a>
                    </nav>
                </div>
            </div>
            <div className="footer-credit">
                <p>Created by <span>Website Masters</span> | All rights reserved.</p>
            </div>
        </footer>
    );
};

export default Footer;
