class SelectSeatRadioButton extends React.Component {
    render() {
        return (
            <div>
                <div class="input-group mb-3">
                    <div class="custom-control custom-radio custom-control-inline">
                        <input type="radio" id="customRadioInline1" name="customRadioInline1" class="custom-control-input" />
                        <label class="custom-control-label" for="customRadioInline1">Toggle this custom radio</label>
                    </div>
                    <div class="custom-control custom-radio custom-control-inline">
                        <input type="radio" id="customRadioInline2" name="customRadioInline1" class="custom-control-input" />
                        <label class="custom-control-label" for="customRadioInline2">Or toggle this other custom radio</label>
                    </div>
                </div>

                <AddressPicker postcode="BS9 1RW" />
            </div>            
        );
    }
}

class AddressPicker extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            data: []
        }
    }
    componentWillMount() {
        const xhr = new XMLHttpRequest();
        xhr.open('get', "VotePledge/Addresses?postcode=" + this.props.postcode, true);
        xhr.onload = () => {
            const data = JSON.parse(xhr.responseText);
            this.setState({ data: data });
        };
        xhr.send();
    }
    render() {
        return (
            <div class="input-group mb-3">
                <div class="input-group-prepend">
                    <label class="input-group-text" for="inputGroupSelect01">Options</label>
                </div>
                <select class="custom-select" id="inputGroupSelect01">
                    <option selected>Choose...</option>
                    {const commentNodes = this.props.data.map(address => (
                        <option selected>{address.FirstLine}</option>
                    ));}
                </select>
            </div>
        );
    }
}

ReactDOM.render(<SelectSeatRadioButton />, document.getElementById('content'));