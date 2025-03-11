import React from "react";
import "./Doctors.css";

const Doctors = () => {
  return (
    <section id="doctor" className="card">
      <div className="container">
        <h1 className="heading">Doctors</h1>
        <h3 className="title">Our Professional Doctors</h3>

        <div className="box-container">
          {/* Doctor 1 */}
          <div className="box">
            <img
              src="https://as2.ftcdn.net/v2/jpg/03/20/52/31/1000_F_320523164_tx7Rdd7I2XDTvvKfz2oRuRpKOPE5z0ni.jpg"
              alt="Dr. John Doe"
            />
            <div className="content">
              <a href="#">
                <h2>John Doe</h2>
              </a>
              <p>Cardiologist</p>
              <div className="social-icons">
                <a href="#" className="fab fa-facebook-f"></a>
                <a href="#" className="fab fa-twitter"></a>
                <a href="#" className="fab fa-instagram"></a>
                <a href="#" className="fab fa-linkedin"></a>
              </div>
            </div>
          </div>

          {/* Doctor 2 */}
          <div className="box">
            <img
              src="https://as1.ftcdn.net/v2/jpg/03/13/77/82/1000_F_313778250_Y0o5can6MA490Nt7G6p03Zfu5fKmWCIv.jpg"
              alt="Dr. Elizabeth Blackwell"
            />
            <div className="content">
              <a href="#">
                <h2>Elizabeth Blackwell</h2>
              </a>
              <p>Pediatrician</p>
              <div className="social-icons">
                <a href="#" className="fab fa-facebook-f"></a>
                <a href="#" className="fab fa-twitter"></a>
                <a href="#" className="fab fa-instagram"></a>
                <a href="#" className="fab fa-linkedin"></a>
              </div>
            </div>
          </div>

          {/* Doctor 3 */}
          <div className="box">
            <img
              src="https://t4.ftcdn.net/jpg/02/60/04/09/240_F_260040900_oO6YW1sHTnKxby4GcjCvtypUCWjnQRg5.jpg"
              alt="Dr. Robert James"
            />
            <div className="content">
              <a href="#">
                <h2>Robert James</h2>
              </a>
              <p>Dermatologist</p>
              <div className="social-icons">
                <a href="#" className="fab fa-facebook-f"></a>
                <a href="#" className="fab fa-twitter"></a>
                <a href="#" className="fab fa-instagram"></a>
                <a href="#" className="fab fa-linkedin"></a>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
  );
};

export default Doctors;