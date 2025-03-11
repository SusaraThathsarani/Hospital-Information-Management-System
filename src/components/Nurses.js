import React from "react";
import "./Nurses.css";

const Nurses = () => {
  return (
    <section id="nurse" className="card">
      <div className="container">
        <h1 className="heading">Nurses</h1>
        <h3 className="title">Our Professional Nurses</h3>

        <div className="box-container">
          {/* Nurse 1 */}
          <div className="box">
            <img
              src="https://as2.ftcdn.net/v2/jpg/00/71/21/03/1000_F_71210371_msN66xnHCni49wTen8rpv64SW3T6sStV.jpg"
              alt="Lucy Eleanor"
            />
            <div className="content">
              <a href="#">
                <h2>Lucy Eleanor</h2>
              </a>
              <p>Professional Nurse</p>
              <div className="icons">
                <a href="#" className="fab fa-facebook-f"></a>
                <a href="#" className="fab fa-twitter"></a>
                <a href="#" className="fab fa-instagram"></a>
              </div>
            </div>
          </div>

          {/* Nurse 2 */}
          <div className="box">
            <img
              src="https://as2.ftcdn.net/v2/jpg/05/53/22/99/1000_F_553229992_bjvQkRLRGLuA2a6yQQMnvmR4obPmZq2r.jpg"
            />
            <div className="content">
              <a href="#">
                <h2>Hazel James</h2>
              </a>
              <p>Professional Nurse</p>
              <div className="icons">
                <a href="#" className="fab fa-facebook-f"></a>
                <a href="#" className="fab fa-twitter"></a>
                <a href="#" className="fab fa-instagram"></a>
              </div>
            </div>
          </div>

          {/* Nurse 3 */}
          <div className="box">
            <img
              src="https://t4.ftcdn.net/jpg/01/35/01/77/360_F_135017712_nFjDc1RjPAsuDB0EWYap9a2gP2xMWr89.jpg"
              alt="Oscar James"
            />
            <div className="content">
              <a href="#">
                <h2>Oscar James</h2>
              </a>
              <p>Professional Nurse</p>
              <div className="icons">
                <a href="#" className="fab fa-facebook-f"></a>
                <a href="#" className="fab fa-twitter"></a>
                <a href="#" className="fab fa-instagram"></a>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
  );
};

export default Nurses;
