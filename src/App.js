import React from 'react';
import Header from './components/Header';
import Home from './components/Home';
import About from './components/About';
import Doctors from './components/Doctors';
import Nurses from './components/Nurses';
import Contact from './components/Contact';
import Blog from './components/Blog';
import Footer from './components/Footer';
import Reviews from './components/Reviews';
import './App.css';

function App() {
    return (
        <div className="App">
            <Header />
            <div className="content">
                <Home />
                <About />
                <Doctors />
                <Nurses />
                <Reviews />
                <Contact />
                <Blog />
            </div>
            <Footer />
        </div>
    );
}

export default App;