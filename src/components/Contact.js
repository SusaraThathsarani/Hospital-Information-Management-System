import React, { useState, useEffect } from 'react';
import './Contact.css';
import { FaUser, FaEnvelope, FaPhone, FaPaperPlane, FaEdit, FaTrash } from 'react-icons/fa';

const Contact = () => {
    const [formData, setFormData] = useState({
        name: '',
        email: '',
        phone: '',
        message: ''
    });

    const [submissionStatus, setSubmissionStatus] = useState(null);
    const [messages, setMessages] = useState([]);
    const [editingId, setEditingId] = useState(null);

    useEffect(() => {
        fetchMessages();
    }, []);

    const fetchMessages = async () => {
        try {
            const response = await fetch('http://localhost:5000/api/messages');
            const result = await response.json();

            if (result.success) {
                setMessages(result.messages);
            } else {
                console.error('Failed to fetch messages');
            }
        } catch (error) {
            console.error('Error fetching messages:', error);
        }
    };

    const handleChange = (e) => {
        const { name, value } = e.target;
        setFormData({ ...formData, [name]: value });
    };

    const handleSubmit = async (e) => {
        e.preventDefault();
        setSubmissionStatus(null);

        try {
            const url = editingId
                ? `http://localhost:5000/api/contact/${editingId}`
                : 'http://localhost:5000/api/contact';

            const method = editingId ? 'PUT' : 'POST';

            const response = await fetch(url, {
                method,
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify(formData)
            });

            const result = await response.json();

            if (result.success) {
                setSubmissionStatus('success');
                setFormData({ name: '', email: '', phone: '', message: '' });
                setEditingId(null);
                fetchMessages();
            } else {
                setSubmissionStatus('error');
            }
        } catch (error) {
            console.error('Error:', error);
            setSubmissionStatus('error');
        }
    };

    const handleEdit = (message) => {
        setFormData(message);
        setEditingId(message.id);
    };

    const handleDelete = async (id) => {
        if (!window.confirm('Are you sure you want to delete this message?')) return;

        try {
            const response = await fetch(`http://localhost:5000/api/contact/${id}`, {
                method: 'DELETE'
            });

            const result = await response.json();
            if (result.success) {
                fetchMessages();
            } else {
                console.error('Failed to delete message');
            }
        } catch (error) {
            console.error('Error deleting message:', error);
        }
    };

    return (
        <section id="contact" className="contact">
            <h1 className="heading">Contact Us</h1>
            <form className="form-container" onSubmit={handleSubmit}>
                <input type="text" name="name" placeholder="Full Name" value={formData.name} onChange={handleChange} required />
                <input type="email" name="email" placeholder="Enter your email" value={formData.email} onChange={handleChange} required />
                <input type="text" name="phone" placeholder="Phone" value={formData.phone} onChange={handleChange} required />
                <textarea name="message" placeholder="Your Message" value={formData.message} onChange={handleChange} required></textarea>
                <button type="submit">{editingId ? 'Update' : 'Send'}</button>
                {submissionStatus === 'success' && <p className="success-message">Message sent successfully!</p>}
                {submissionStatus === 'error' && <p className="error-message">Failed to send message. Please try again.</p>}
            </form>

            <div className="sent-messages">
                <h3>Sent Messages</h3>
                {messages.map((message) => (
                    <div key={message.id} className="message-item">
                        <p><strong>Name:</strong> {message.name}</p>
                        <p><strong>Email:</strong> {message.email}</p>
                        <p><strong>Phone:</strong> {message.phone}</p>
                        <p><strong>Message:</strong> {message.message}</p>
                        <button onClick={() => handleEdit(message)}><FaEdit /> Edit</button>
                        <button onClick={() => handleDelete(message.id)}><FaTrash /> Delete</button>
                    </div>
                ))}
            </div>
        </section>
    );
};

export default Contact;



