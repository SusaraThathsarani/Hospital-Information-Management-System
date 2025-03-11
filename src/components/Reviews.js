import React from "react";
import './Reviews.css';

const Reviews = () => {
  return (
    <section id="review" className="review">
      <h1 className="heading">Our Patient Reviews</h1>
      <h3 className="title">What Patients Say About Us</h3>

      <div className="box-container">
        {/* Review 1 */}
        <div className="box">
          <i className="fas fa-quote-left"></i>
          <p>
            I appreciate the ease of access to patient records through the
            HIMS.
          </p>
          <div className="info">
            <h3>John Doe</h3>
            <span>Date: 11 2024</span>
          </div>
        </div>

        {/* Review 2 */}
        <div className="box">
          <i className="fas fa-quote-left"></i>
          <p>
            I appreciate being able to access my test results and medical
            history online through the patient portal.
          </p>
          <div className="info">
            <h3>Jane Smith</h3>
            <span>Date: 11 2024</span>
          </div>
        </div>

        {/* Review 3 */}
        <div className="box">
          <i className="fas fa-quote-left"></i>
          <p>
            I wish the system provided more detailed information about my
            medications and their potential side effects.
          </p>
          <div className="info">
            <h3>Sarah Connor</h3>
            <span>Date: 11 2024</span>
          </div>
        </div>
      </div>
    </section>
  );
};

export default Reviews;
