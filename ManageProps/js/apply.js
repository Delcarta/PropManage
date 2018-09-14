$(document).ready(function () {
    $("div.petRow input").blur(function () {
        StorePets(this);
    });

    $("div.occupantRow input").blur(function () {
        StoreOccupants(this);
    });

    $("div.primaryApplicantEmpHisRow input").blur(function () {
        StoreEmploymentHistory(this, "#hdEmpHistoryPrimary");
    });
});

function StorePets(PetBox) {
    var petInfo = $(PetBox).closest('div.petRow').find('input');
    var type = petInfo[0].value;
    var breed = petInfo[1].value;
    var deposit = petInfo[2].value;
    var index = petInfo[3].value;
    if (type && breed) {
        //Get existing json
        var existingPetsJson = $('#hdPets').val();
        if (existingPetsJson.length == 0) {
            //no pets. overwrite
            var aPet = { "index": index, "type": type, "breed": breed, "deposit": deposit }
            var aPetKennel = [aPet];

            $('#hdPets').val(JSON.stringify(aPetKennel));
        }
        else {
            //existing pets. add.
            var aPetKennel = JSON.parse(existingPetsJson);
            aPetKennel = $.grep(aPetKennel, function (box, i) { return box.index != index; });
            var aPet = { "index": index, "type": type, "breed": breed, "deposit": deposit }
            aPetKennel.push(aPet);
            $('#hdPets').val(JSON.stringify(aPetKennel));
        }
    }
}

function StoreOccupants(personBox)
{
    var personInfo = $(personBox).closest('div.occupantRow').find('input');
    var name = personInfo[0].value;
    var dob = personInfo[1].value;
    var index = personInfo[2].value;

    if (name && dob)
    {
        //Get existing json
        var existingOccupantJson = $('#hdOccupants').val();
        if (existingOccupantJson.length == 0) {
            //no other occupants. overwrite
            var aPerson = { "index": index, "name": name, "dob": dob }
            var aHouse = [aPerson];

            $('#hdOccupants').val(JSON.stringify(aHouse));
        }
        else {
            //existing occupants. add.
            var aHouse = JSON.parse(existingOccupantJson);
            aHouse = $.grep(aHouse, function (box, i) { return box.index != index; });
            var aPerson = { "index": index, "name": name, "dob": dob }
            aHouse.push(aPerson);
            $('#hdOccupants').val(JSON.stringify(aHouse));
        }
    }
}

function StoreEmploymentHistory(EmpBox, dest)
{
    var jobInfo = $(EmpBox).closest('div.primaryApplicantEmpHisRow').find('input');
    var type = jobInfo[0].value;
    var breed = jobInfo[1].value;
    var deposit = jobInfo[2].value;
    var index = jobInfo[3].value;
    if (type && breed) {
        //Get existing json
        var existingPetsJson = $('#hdPets').val();
        if (existingPetsJson.length == 0) {
            //no pets. overwrite
            var aPet = { "index": index, "type": type, "breed": breed, "deposit": deposit }
            var aPetKennel = [aPet];

            $('#hdPets').val(JSON.stringify(aPetKennel));
        }
        else {
            //existing pets. add.
            var aPetKennel = JSON.parse(existingPetsJson);
            aPetKennel = $.grep(aPetKennel, function (box, i) { return box.index != index; });
            var aPet = { "index": index, "type": type, "breed": breed, "deposit": deposit }
            aPetKennel.push(aPet);
            $('#hdPets').val(JSON.stringify(aPetKennel));
        }
    }
}

function RemoveExisting(box, ix, selectedIndex) {
    //box is item in array.  ix is the index of item in array.  selectedIndex is id of identifier of item to remove
    return box.index != selectedIndex;
}

function Copy(CopyFrom, CopyTo) {
    var theClone = $(CopyFrom).clone(true, true).insertAfter(CopyTo);
    var theIndex = theClone.find('input[type=hidden]');
    theClone.find('input').not(':button, :submit, :reset, :hidden').val('');
    var indexPosition = parseInt(theIndex.val());
    theIndex.val(indexPosition + 1);
}